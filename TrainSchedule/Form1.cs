using TrainSchedule.Services;
using TrainSchedule.Models;
using TrainSchedule.Repositories;
using TrainSchedule.RepositoryInterfaces;

namespace TrainSchedule
{
    public partial class TrainSchedule : Form
    {
        public TrainSchedule()
        {
            InitializeComponent();
        }

        public void AddPassanger(Passenger passenger)
        {
            // Добавить строку с ФИО и контактами добавленного пассажира.
            this.passengers.Rows.Add(passenger.LastName, passenger.FirstName, passenger.Patronim, passenger.Contacts, passenger.Id);

            // Отсортировать таблицу согласно фамилии.
            this.passengers.Sort(last_name, System.ComponentModel.ListSortDirection.Ascending);
        }

        public void AddTicket()
        {
            this.tickets.Rows.Clear(); // Очистить таблицу билетов.

            int selectedRowIndex = passengers.SelectedCells[0].RowIndex; // Получить индекс просматриваемой записи.
            long id = Convert.ToInt32(passengers[4, selectedRowIndex].Value); // Получить значение, по которому вывести список билетов из БД.

            // Получить список билетов и информацию о них для конкретного пользователя.
            DbTicketServices serv = new DbTicketServices();
            IEnumerable<Train> trainsList = null;
            IEnumerable<Locality> localityList = null;
            IEnumerable<DateTime> arrTimes = null;
            IEnumerable<DateTime> depTimes = null;
            IEnumerable<Ticket> ticketList = serv.GetInfoAboutTicketsByPassenger(new Passenger(id, "", "", "", ""), out trainsList, out localityList, out arrTimes, out depTimes);

            // Добавить записи о билетах в таблицу.
            int i = 0;
            foreach (Ticket ticket in ticketList)
            {
                this.tickets.Rows.Add(trainsList.ToArray()[i].TrainNumber, localityList.ToArray()[i].Name, depTimes.ToArray()[i], arrTimes.ToArray()[i], ticket.Id);
            }
        }

        public long GetPassengerId()
        {
            int column = 4;
            int selectedRowIndex = passengers.SelectedCells[0].RowIndex; // Получить индекс текцщей записи.
            long id = Convert.ToInt32(passengers[column, selectedRowIndex].Value); // Получить значение.
            return id;
        }

        public void UpdatePassanger(Passenger passenger)
        {
            int selectedRowIndex = passengers.SelectedCells[0].RowIndex; // Получить индекс обновляемой записи.                                                                       

            // Удалить запись из таблицы.
            passengers.Rows.RemoveAt(selectedRowIndex); 
            passengers.Refresh();

            // Добавить обновлённую запись в таблицу.
            AddPassanger(passenger);
        }

        public void UpdateTicket()
        {
            int selectedRowIndex = tickets.SelectedCells[0].RowIndex; // Получить индекс обновляемой записи.                                                                       

            // Удалить запись из таблицы.
            tickets.Rows.RemoveAt(selectedRowIndex);
            tickets.Refresh();

            // Добавить обновлённую запись в таблицу.
            AddTicket();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создать репозиторий для работы с таблицей Passengers БД.
            IPassengerRepository rep = new MySqlDbPassangerRepository();

            // Получить список всех пассажиров.
            IEnumerable<Passenger> passes = rep.GetAll();

            // Для каждого элемента коллекции...
            foreach (Passenger passenger in passes)
            {
                // ...Добавить строку о пассажире в таблицу
                this.passengers.Rows.Add(passenger.LastName, passenger.FirstName, passenger.Patronim, passenger.Contacts, passenger.Id);
            }

            this.passengers.Sort(last_name, System.ComponentModel.ListSortDirection.Ascending);  // Отсортировать таблицу.

            IReviewRepository reviewer = new MySqlDbReviewRepository();
            IEnumerable<Review> reviews = reviewer.GetAll();
            foreach(Review review in reviews)
            {
                if (review.Id != 13)
                {
                    if (review.Name == null) review.Name = "[Пустой отзыв]";
                    this.reviews.Rows.Add(review.Name, review.Description, review.Evaluation, review.Id);
                }
            }
        }

        private void Delete_pass_Click(object sender, EventArgs e)
        {
            if (this.passengers.CurrentRow != null)
            {
                int column = 4;
                int selectedRowIndex = passengers.SelectedCells[0].RowIndex; // Получить индекс удляемой записи.
                long id = Convert.ToInt32(passengers[column,selectedRowIndex].Value); // Получить значение, по которому нужно удалить запись из БД.

                // Удалить запись из БД
                DbPassengerServices service = new DbPassengerServices(); 
                service.DeletePassenger(id);
                
                // Удалить запись из таблицы.
                passengers.Rows.RemoveAt(selectedRowIndex);
                passengers.Refresh();
            }
        }

        private void Add_pass_Click(object sender, EventArgs e)
        {
            Add_form form = new Add_form(this); // Создать форму для создания пассажира.
            form.ShowDialog(this); // Запустить форму из главного родительского окна.
        }

        private void passengers_SelectionChanged(object sender, EventArgs e)
        {
            if (this.passengers.CurrentRow != null) // Если выбрана какая-либо строка в таблице пассажиров...
            {
                this.Update_pass.Enabled = true; // Сделать возможным редактирование и удаление записей
                this.Delete_pass.Enabled = true;

                this.tickets.Rows.Clear(); // Очистить таблицу билетов.

                int selectedRowIndex = passengers.SelectedCells[0].RowIndex; // Получить индекс просматриваемой записи.
                long id = Convert.ToInt32(passengers[4, selectedRowIndex].Value); // Получить значение, по которому вывести список билетов из БД.

                // Получить список билетов и информацию о них для конкретного пользователя.
                DbTicketServices serv = new DbTicketServices(); 
                IEnumerable<Train> trainsList = null;
                IEnumerable<Locality> localityList = null;
                IEnumerable<DateTime> arrTimes = null;
                IEnumerable<DateTime> depTimes = null;
                IEnumerable<Ticket> ticketList = serv.GetInfoAboutTicketsByPassenger(new Passenger(id, "","", "", ""),out trainsList, out localityList, out arrTimes, out depTimes);

                // Добавить записи о билетах в таблицу.
                int i = 0;
                foreach (Ticket ticket in ticketList)
                {
                    this.tickets.Rows.Add(trainsList.ToArray()[i].TrainNumber, localityList.ToArray()[i].Name, depTimes.ToArray()[i], arrTimes.ToArray()[i], ticket.Id);
                }
            }
            
            else // Иначе...
            { 
                this.Update_pass.Enabled = false; // Запретить возможность удаления и редактирования записей.
                this.Delete_pass.Enabled= false;
                this.tickets.Rows.Clear(); // Очистить таблицу информации о билетах.
            }
            this.SummaryCost.Text = "";
        }

        private void Update_pass_Click(object sender, EventArgs e)
        {
            this.passengers.Enabled = false;
            int column = 4;
            int selectedRowIndex = passengers.SelectedCells[0].RowIndex; // Получить индекс обновляемой записи.
            long id = Convert.ToInt32(passengers[column, selectedRowIndex].Value); // Получить значение, по которому нужно обновить запись в БД.

            // Запустить форму из главного родительского окна.
            Update_form form = new Update_form(this, id);
            form.ShowDialog();
            this.passengers.Enabled = true;
        }

        private void Add_ticket_btn_Click(object sender, EventArgs e)
        {
            Add_ticket form = new Add_ticket(this);
            form.ShowDialog(this);
        }

        private void tickets_SelectionChanged(object sender, EventArgs e)
        {
            if (this.tickets.CurrentRow != null) // Если никакая строка не выбрана
            {
                this.updateTicketBtn.Enabled = true;
                this.deleteTicketBtn.Enabled = true; // Разрешить удаление записей о билете.
              
            }
            else // Иначе...
            {
                this.updateTicketBtn.Enabled = false;
                this.deleteTicketBtn.Enabled = false; // Запретить удаление.
            }
            this.AverageRating.Text = "";
        }

        private void deleteTicketBtn_Click(object sender, EventArgs e)
        {
            if (this.tickets.CurrentRow != null)
            {
                int column = 4;
                int selectedRowIndex = tickets.SelectedCells[0].RowIndex; // Получить индекс удляемой записи.
                long id = Convert.ToInt32(tickets[column, selectedRowIndex].Value); // Получить значение, по которому нужно удалить запись из БД.

                // Удалить запись из БД
                DbTicketServices service = new DbTicketServices();
                service.DeleteTicket(id);

                // Удалить запись из таблицы.
                tickets.Rows.RemoveAt(selectedRowIndex);
                tickets.Refresh();
            }
        }

        private void updateTicketBtn_Click(object sender, EventArgs e)
        {
            this.tickets.Enabled = false;
            int column = 4;
            int selectedRowIndex = tickets.SelectedCells[0].RowIndex; // Получить индекс обновляемой записи.
            long id = Convert.ToInt32(tickets[column, selectedRowIndex].Value); // Получить значение, по которому нужно обновить запись в БД.

            Update_ticket form = new Update_ticket(this, id);
            form.ShowDialog();
        }

        private void AverageRating_Click(object sender, EventArgs e)
        {
            if ((this.tickets.SelectedRows.Count > 0)&&(this.tickets.CurrentRow != null)) // Если выбран какой-либо билет.
            {
                MySqlDbReviewRepository rep = new MySqlDbReviewRepository();

                int selectedRowIndex = tickets.SelectedCells[0].RowIndex; // Получить индекс требуемой записи.
                long number = Convert.ToInt32(tickets[0, selectedRowIndex].Value); // Получить значение, по которому нужно получить данные из БД.

                float rat = rep.GetAverageEvaluationByTrain(new Train(number, "", number, false));// Получить среднюю оценку обслуживания.
                this.AverageRating.Text = rat.ToString(); // Вывести оценку в виджет
            } 
            else // Иначе...
            {
                //Считать ретинг равный 0;
                float rating = 0;
                this .AverageRating.Text = rating.ToString(); // Вывести оцнку в виджет.
            }
        }

        private void SummaryCost_Click(object sender, EventArgs e)
        {
            if ((this.passengers.SelectedRows.Count > 0) && (this.tickets.SelectedRows.Count > 0)) // ЕСли выбран какой-либо пассажир.
            {
                int selectedRowIndex = passengers.SelectedCells[0].RowIndex; // Получить индекс требуемой записи.
                long number = Convert.ToInt32(passengers[4, selectedRowIndex].Value); // Получить значение, по которому нужно получить данные из БД.

                MySqlDbTicketRepository rep = new MySqlDbTicketRepository();
                float cost = rep.GetSummaryCost(new Passenger(number,"","","","")); // Получить общую стоимость билетов.
                this.SummaryCost.Text = cost.ToString(); // Вывести стоимость в виджет.
            }
            else // Иначе...
            {
                float cost = 0; //Считать общую стоимоть равной 0
                this.SummaryCost.Text = cost.ToString(); //Вывести стоимость в виджет.
            }
        }
    }
}