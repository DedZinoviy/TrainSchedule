using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainSchedule.Repositories;
using TrainSchedule.Models;
using TrainSchedule.Services;

namespace TrainSchedule
{
    public partial class Add_ticket : Form
    {
        private TrainSchedule Schedule;
        public Add_ticket(TrainSchedule schedule)
        {
            Schedule = schedule;
            InitializeComponent();
        }

        private void Add_ticket_Load(object sender, EventArgs e)
        {
            MySqlDbTrainRepository trainRepository = new MySqlDbTrainRepository(); // Создать объект репозиория поездов.
            IEnumerable<Train> trains = trainRepository.GetAll(); // Получить список всех поездов.
            foreach (Train train in trains) // Для каждого полученного элемента...
            {
                this.trains.Rows.Add(train.TrainNumber, train.Id); // Добавить элемент в таблицу
            }
            this.trains.Sort(trainNumber, System.ComponentModel.ListSortDirection.Ascending); // Упорядочить таблицу.
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            long pasId = Schedule.GetPassengerId(); // Узнать, какой пассажир приоборетает билет.
            DbTicketServices serv =new DbTicketServices(); // Создать объект службы для работы с билетами.
            long trainId = Convert.ToInt32(this.trains[1,this.trains.CurrentRow.Index].Value); // Узнать на какой поезд покупается билет.
            long seatId = Convert.ToInt32(this.places[1, this.places.CurrentRow.Index].Value); // Узнать на какое место покупается билет.
            int avail = 0;
            float cost = (float)this.cost.Value; // Узнать стоимость билета.
            serv.AppendNewTicket(trainId,seatId,pasId,cost,avail); // Добавить сущность билета в БД.
            Schedule.AddTicket();
            this.Close(); // Закрыть окно.
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trains_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowIndex = trains.SelectedCells[0].RowIndex; // Получить индекс текущей записи.
            long id = Convert.ToInt32(trains[1, selectedRowIndex].Value); // Получить значение, по которому нужно найти запись из БД.
            MySqlDbWagonRepository repository = new MySqlDbWagonRepository(); // Создать репозиторий для работы с Wagons.
            IEnumerable<Wagon> wagons = repository.GetByTrain(new Train(id, " ", 0, false)); //Получить список вагонов для поезда.
            this.wagons.Rows.Clear(); // Очистить таблицу вагонов.
            this.places.Rows.Clear(); // Очистить таблицу билетов.
            foreach (Wagon wagon in wagons) // Для каждого элемента коллекции...
            {
                this.wagons.Rows.Add(wagon.Number, wagon.Id); // Добавить элемент в таблицу.
            }

            this.wagons.Sort(wagonNumber, System.ComponentModel.ListSortDirection.Ascending); // Упорядочить таблицу.
            this.wagons.ClearSelection(); // Очистить выбор.
            this.WagonsCount.Text = "";
            this.PlacesCount.Text = "";
        }

        private void wagons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = wagons.SelectedCells[0].RowIndex; // Получить индекс текущей записи.
            long id = Convert.ToInt32(wagons[1, selectedRowIndex].Value); // Получить значение, по которому нужно найти запись из БД.
            MySqlDbSeatRepository repository = new MySqlDbSeatRepository(); // Создать репозиторий для работы с Places.
            IEnumerable<Seat> seats = repository.GetFreeSeatByWagon(new Wagon(id, 0, 0)); //Получить список свободных мест в поезде.
            this.places.Rows.Clear(); // Очистить таблицу.
            foreach (Seat seat in seats) //  Для каждого элемента коллекции...
            {
                this.places.Rows.Add(seat.Number, seat.Id); // Добавить элемент в таблицу.
            }
            this.places.Sort(placeNumber, System.ComponentModel.ListSortDirection.Ascending); // Упорядочить таблицу.

        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = trains.SelectedCells[0].RowIndex; // Получить индекс текущей записи.
            long num = Convert.ToInt32(trains[0, selectedRowIndex].Value); // Получить значение, по которому нужно найти запись из БД.
            MySqlDbTrainRepository repository = new MySqlDbTrainRepository();
            int placesCount;
            int wagonsCount = repository.GetInfoAboutWagonsAndPlaces(new Train(num,"",num,false),out placesCount);
            this.PlacesCount.Text = placesCount.ToString();
            this.WagonsCount.Text = wagonsCount.ToString();
        }
    }
}
