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

        public void UpdatePassanger(Passenger passenger)
        {
            int selectedRowIndex = passengers.SelectedCells[0].RowIndex; // Получить индекс обновляемой записи.                                                                       

            // Удалить запись из таблицы.
            passengers.Rows.RemoveAt(selectedRowIndex); 
            passengers.Refresh();

            // Добавить обновлённую запись в таблицу.
            AddPassanger(passenger);
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
            Add_ticket form = new Add_ticket();
            form.ShowDialog(this);
        }
    }
}