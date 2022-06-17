using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainSchedule.Models;
using TrainSchedule.Repositories;
using TrainSchedule.Services;

namespace TrainSchedule
{
    public partial class Add_form : Form
    {
        public Add_form()
        {
            InitializeComponent();
        }

        private void Add_form_Load(object sender, EventArgs e)
        {
           
        }

        private void Cancel_add_pass_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_add_pass_btn_Click(object sender, EventArgs e)
        {
            // Получить данные из полей для ввода
            string firstName = this.FirstNamePassEdit.Text;
            string lastName = this.LastNamePassEdit.Text;
            string patronim = this.PatronimPassEdit.Text;
            string contact = this.ContactsPassEdit.Text;
            int error;

            // Добавить в БД объект пользователя согласно данным из формы
            DbPassengerServices services = new DbPassengerServices();
            services.AppendNewPassenger(firstName, lastName, patronim, contact, out error);

            // Завершить добавление, закрыв форму.
            this.Close();

        }
    }
}
