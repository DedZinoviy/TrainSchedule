using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainSchedule.Services;
using TrainSchedule.Models;

namespace TrainSchedule
{
    public partial class Update_form : Form
    {
        private TrainSchedule Schedule;
        private long updateId;

        public Update_form(TrainSchedule schedule, long id_for_update)
        {
            InitializeComponent();
            Schedule = schedule;
            updateId = id_for_update;
        }

        private void Update_form_Load(object sender, EventArgs e)
        {

        }

        private void Save_add_pass_btn_Click(object sender, EventArgs e)
        {
            // Получить данные из полей для ввода
            string firstName = this.FirstNamePassEdit.Text;
            string lastName = this.LastNamePassEdit.Text;
            string patronim = this.PatronimPassEdit.Text;
            string contact = this.ContactsPassEdit.Text;
            int error;
            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(patronim) || String.IsNullOrEmpty(contact)) //  Если хотя бы одно текстовое поле пустое...
            {
                // Сообщить об ошибке ввода.
                const string message = "Текстовые поля для ввода не должны быть пустыми.";
                const string caption = "Ошибка ввода";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else // Иначе...
            {
                // Добавить в БД объект пользователя согласно данным из формы
                DbPassengerServices services = new DbPassengerServices();
                Passenger passenger = services.UpdatePassenger(updateId, lastName, firstName, patronim, contact);

                // Вернуть объект родительскому окну.
                Schedule.UpdatePassanger(passenger);

                // Завершить добавление, закрыв форму.
                this.Close();
            }
        }

        private void Cancel_add_pass_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
