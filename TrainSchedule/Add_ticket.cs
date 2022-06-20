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

namespace TrainSchedule
{
    public partial class Add_ticket : Form
    {
        public Add_ticket()
        {
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
            this.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trains_SelectionChanged(object sender, EventArgs e)
        {
            this.wagons.Rows.Clear(); // Очистить таблицу
            int selectedRowIndex = trains.SelectedCells[0].RowIndex; // Получить индекс удляемой записи.
            long id = Convert.ToInt32(trains[1, selectedRowIndex].Value); // Получить значение, по которому нужно удалить запись из БД.
            MySqlDbWagonRepository repository = new MySqlDbWagonRepository(); // Создать репозиторий для работы с Wagons.
            IEnumerable<Wagon> wagons = repository.GetByTrain(new Train(id, " ", 0, false)); //Получить список вагонов для поезда.
            foreach (Wagon wagon in wagons) // Для каждого элемента коллекции...
            {
                this.wagons.Rows.Add(wagon.Number, wagon.Id); // Добавить элемент в таблицу.
            }
            this.wagons.Sort(wagonNumber, System.ComponentModel.ListSortDirection.Ascending); // Упорядочить таблицу.
        }
    }
}
