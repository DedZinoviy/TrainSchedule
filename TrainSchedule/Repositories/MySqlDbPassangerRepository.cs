using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.RepositoryInterfaces;
using TrainSchedule.Models;
using MySql.Data.MySqlClient;
using TrainSchedule.Conections;

namespace TrainSchedule.Repositories
{
    public class MySqlDbPassangerRepository : IPassengerRepository
    {
        public Passenger Update(Passenger passenger)
        {
            throw new NotImplementedException();
        }

        public Passenger Append(Passenger newPassenger)
        {
            string sql = "INSERT INTO trains.passangers (first_name,last_name,patronim,contacts) VALUES (@f_name, @l_name, @ptr, @ctc)"; // Сформировать строку SQL-запроса на добавление данных в таблицу localities

            using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД MySql

            connection.Open(); // Открыть соединение

            try // Попытаться...
            {
                using MySqlCommand command = new MySqlCommand(sql, connection); // Сформировать готовый SQL-запрос на добавление в таблицу localities
                command.Parameters.AddWithValue("@f_name", newPassenger.FirstName); // Присвоить значения параметров SQL-запросу
                command.Parameters.AddWithValue("@l_name", newPassenger.LastName);
                command.Parameters.AddWithValue("@ptr", newPassenger.Patronim);
                command.Parameters.AddWithValue("@ctc", newPassenger.Contacts);

                command.ExecuteNonQuery(); // Выполнить SQL-запрос
                long localityId = command.LastInsertedId; // Узнать id объекта, который он получил в таблице БД
                newPassenger.Id = localityId; // Присвоить этот id экземпляру этого объекта внутри приложения
                return newPassenger; // Вернуть добавленный объект
            }
            catch (MySqlException exception) // Иначе... 
            {
                throw new RepositoryException(exception.ErrorCode, exception.Message); // Сообщить об ошибке
            }
        }

        public void Delete(Passenger passenger)
        {
            throw new NotImplementedException();
        }

        public Passenger GetById(long id)
        {
            return null;
        }

        public IEnumerable<Passenger> GetAll()
        {
            List<Passenger> passengers = new List<Passenger>(); // Считать, что изначально в БД нет пассажиров.
            string query = @"SELECT * FROM trains.passengers"; // Сформировать строку запроса на получение списка пассажиров.
            using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД.
            connection.Open(); // Открыть соединение
            try // Попытаться...
            {
                using MySqlCommand command = new MySqlCommand(query, connection); // Сформировать запрос на получение списка пассажиров.
                using MySqlDataReader reader = command.ExecuteReader();  // Выплнить запрос
                while(reader.Read()) // Пока имеются полученные объекты...
                {
                    long idPassenger = reader.GetInt32(0); // Получить данные о пассажирах.
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string patronim = reader.GetString(3);
                    string contacts = reader.GetString(4);

                    passengers.Add(new Passenger(idPassenger, firstName, lastName, patronim, contacts)); // Добавить сформированные объекты пассажиров в коллекцию.
                }
                return passengers; // Вернуть коллекцию.
            }
            catch (MySqlException ex) // Иначе...
            {
                throw new RepositoryException(ex.ErrorCode, ex.Message); // Вывести исключение.
            }
            
        }
    }
}
