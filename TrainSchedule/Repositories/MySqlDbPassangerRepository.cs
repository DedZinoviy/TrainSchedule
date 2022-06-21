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
            string sql = @"UPDATE trains.passangers SET first_name = @f_name, last_name = @l_name, patronim = @ptr, contacts = @ctc WHERE idpassangers = @id"; // Сформировать строку SQL-запроса на обновление данных в таблице.
            using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД MySql
            connection.Open(); // Открыть соединение.
            try // Попытаться...
            {
                using MySqlCommand command = new MySqlCommand(sql, connection); // Сформировать готовый SQL-запрос на обновление записи в таблице passangers.
                command.Parameters.AddWithValue("@f_name", passenger.FirstName); // Присвоить значения параметров SQL-запросу.
                command.Parameters.AddWithValue("@l_name", passenger.LastName);
                command.Parameters.AddWithValue("@ptr", passenger.Patronim);
                command.Parameters.AddWithValue("@ctc", passenger.Contacts);
                command.Parameters.AddWithValue("@id", passenger.Id);

                command.ExecuteNonQuery(); // Выполнить  запрос.

                return passenger; // Вернуть объект обновлённого пользователя.
            }
            catch (MySqlException exception) // Иначе...
            {
                throw new RepositoryException(exception.ErrorCode, exception.Message); // Сообщить об ошибке.
            }
        }

        public Passenger Append(Passenger newPassenger)
        {
            string sql = "INSERT INTO trains.passangers (first_name,last_name,patronim,contacts) VALUES (@f_name, @l_name, @ptr, @ctc)"; // Сформировать строку SQL-запроса на добавление данных в таблицу localities

            using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД MySql

            connection.Open(); // Открыть соединение

            try // Попытаться...
            {
                using MySqlCommand command = new MySqlCommand(sql, connection); // Сформировать готовый SQL-запрос на добавление в таблице passangers.
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
            try // Попытаться...
            {
                string ticketSelect = @"SELECT idtickets FROM trains.tickets WHERE passenger_id = @id"; // Сформировать строку запроса на получение списка билетов, закреплённых за пассажром.
                string query = @"DELETE FROM trains.passangers WHERE idpassangers = @id"; // Сформировать строку SQL-запроса на удаление пассажира из таблицы БД.
                using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД MySQL.
                connection.Open(); // Открыть соединение.

                using MySqlCommand ticketCommand = new MySqlCommand(ticketSelect, connection); // Сформировать готовый запрос на получение списка билетов, закреплённых за пасссажиром.
                ticketCommand.Parameters.AddWithValue("@id", passenger.Id); // Присвоить значения переменной готовому SQL-запросы
                using MySqlDataReader ticketReader = ticketCommand.ExecuteReader(); // Получить данные о билетах.
                List<long> ids = new List<long>(); // Считать, что изначально у пассажира нет билетов.
                while (ticketReader.Read()) // Пока имеются возвращённые из запроса билеты...
                {
                    long id = ticketReader.GetInt32(0); // Узнать id билетаю
                    ids.Add(id); // Добавить билет к пассажиру.
                }
                string deleteTTS = "DELETE FROM trains.tickets_to_servcies WHERE ticket_id = @id"; // Сформировать строку запроса на удаление услуг, закреплённых за билетами.
                connection.Close(); // Обновить соединение.
                connection.Open();
                foreach (long id in ids) // Для каждого билета, закреплённого за пассажиром...
                {
                    using MySqlCommand ttsCommand = new MySqlCommand(deleteTTS, connection); // Сформировать готовый запрос на удаление прикреплённых услуг.
                    ttsCommand.Parameters.AddWithValue("@id", id); // Присвоить значения переменной готовому SQL-запросу
                    ttsCommand.ExecuteNonQuery(); // Выполнить запрос.
                }
                connection.Close(); // Обновить соединение;
                connection.Open();
                
                string deleteTickets = "DELETE FROM trains.tickets WHERE idtickets = @id"; // Сформировать строку запроса на удаление билетов, закреплённых за пассажиром.
                using MySqlCommand ticketDeleteCommand = new MySqlCommand(deleteTickets, connection); // Сформировать готовый запрос на удаление билета.
                ticketDeleteCommand.Parameters.AddWithValue("@id", ids[1]); // Присвоить значения переменной готовому SQL-запросу.
                foreach (long id in ids) // Для каждого билета, закреплённого за пассажиром...
                {
                    ticketCommand.Parameters["%id"].Value = id;
                    ticketDeleteCommand.ExecuteNonQuery(); // Выполнить запрос.
                }
                using MySqlCommand command = new MySqlCommand(query, connection); // Сформировать готовый запрос на удаление записи из таблицы Passengers.
                command.Parameters.AddWithValue("@id", passenger.Id); // Присвоить значения переменной готовому SQL-запросы.
                command.ExecuteNonQuery(); // Выполнить SQL-запрос.
            }
            catch (MySqlException exception) //Иначе...
            {
                throw new RepositoryException(exception.ErrorCode, exception.Message); // Сообщить об ошибке.
            }
        }

        public Passenger GetById(long id)
        {
            return null;
        }

        public IEnumerable<Passenger> GetAll()
        {
            List<Passenger> passengers = new List<Passenger>(); // Считать, что изначально в БД нет пассажиров.
            string query = @"SELECT * FROM trains.passangers"; // Сформировать строку запроса на получение списка пассажиров.
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
