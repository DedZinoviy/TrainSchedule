using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;
using TrainSchedule.Repositories;
using TrainSchedule.RepositoryInterfaces;

namespace TrainSchedule.Services
{
    /// <summary>
    /// Class for operations with passengers in different DB tables.
    /// </summary>
    public class DbPassengerServices
    {
        /// <summary>
        /// Passenger Repository Implmentation
        /// </summary>
        private IPassengerRepository passRep;

        /// <summary>
        /// Default Class Constructor
        /// </summary>
        public DbPassengerServices()
        {
            passRep = new MySqlDbPassangerRepository();
        }

        /// <summary>
        /// Append new passenger into Passengers table.
        /// </summary>
        /// <param name="firstName">Passenger's first name</param>
        /// <param name="lastName">Passenger's last name</param>
        /// <param name="patronim">Passenger's patronim</param>
        /// <param name="contacts">Passenger's contacts</param>
        /// <param name="error">Operation success</param>
        /// <returns>Appended passenger object</returns>
        public Passenger AppendNewPassenger(string firstName, string lastName, string patronim, string contacts, out int error)
        {
            // Создать временный объект для добавления в БД
            Passenger newPass = new Passenger(0, firstName, lastName, patronim, contacts);

            // Попытаться...
            try
            {
                // Добавить нового пассажира
                newPass = passRep.Append(newPass);
                error = 0;

                // Вернуть добавленный объект пассажира
                return newPass;
            }
            // Иначе...
            catch (RepositoryException ex)
            {
                // Вернуть исключение.
                error = ex.ErrorCode;
                return null;
                throw ex;
            }
        }

        /// <summary>
        /// Delete passenger from Passengers table.
        /// </summary>
        /// <param name="idPassenger">Passenge's id</param>
        /// <returns>Success of operation</returns>
        public int DeletePassenger(long idPassenger)
        {
            Passenger passenger = new Passenger(idPassenger, "", "", "", "");
            // Попытаться...
            try
            {
                // Удалить пассажира по id.
                passRep.Delete(passenger);

                // Вернуть результат операции.
                return 0;
            }
            // Иначе...
            catch (RepositoryException ex)
            {
                // Вернуть исключение.
                throw ex;
            }
        }

        /// <summary>
        /// Updates passenger record in database.
        /// </summary>
        /// <param name="id">ID of updated passenger.</param>
        /// <param name="lastName">Last name of updated passenger.</param>
        /// <param name="firstName">First name of updated passenger.</param>
        /// <param name="patronim">Patronim of updated passenger.</param>
        /// <param name="contacts">Contacts of updated passenger.</param>
        /// <returns>Updated passenger object.</returns>
        public Passenger UpdatePassenger(long id, string lastName, string firstName, string patronim, string contacts)
        {
            Passenger passenger = new Passenger(id, lastName, firstName, patronim, contacts);
            // Попытаться...
            try
            {
                // Обновить данные в таблице БД о пассажире.
                passenger = passRep.Update(passenger);

                // Вернуть результат операции.
                return passenger;
            }
            // Иначе...
            catch(RepositoryException ex)
            {
                // Сообщить об ошибке.
                throw ex;
            }
        }
    }
}
