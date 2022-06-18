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

        private void Form1_Load(object sender, EventArgs e)
        {
            IPassengerRepository rep = new MySqlDbPassangerRepository();
            IEnumerable<Passenger> passes = rep.GetAll();
            foreach (Passenger passenger in passes)
            {
                this.passengers.Rows.Add(passenger.LastName, passenger.FirstName, passenger.Patronim, passenger.Contacts, passenger.Id);
            }
            this.passengers.Sort(last_name, System.ComponentModel.ListSortDirection.Ascending);
        }

        private void Delete_pass_Click(object sender, EventArgs e)
        {

        }

        private void Add_pass_Click(object sender, EventArgs e)
        {
            Add_form form = new Add_form();
            form.ShowDialog();
        }
    }
}