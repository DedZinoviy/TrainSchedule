using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TrainSchedule.Models;
using TrainSchedule.RepositoryInterfaces;
using TrainSchedule.Conections;

namespace TrainSchedule.Repositories
{
    public class MySqlDbTicketRepository : ITicketRepository
    {
        public Ticket Append(Ticket newTicket)
        {
            string sql = "INSERT INTO trains.tickets (ticket_availability,ticket_cost,passenger_id,review_id, seat_id, route_id) VALUES (@av, @cost, @pas, @review, @seat, @route)"; // Сформировать строку SQL-запроса на добавление данных в таблицу tickets.

            using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД MySql

            connection.Open(); // Открыть соединение

            try // Попытаться...
            {
                using MySqlCommand command = new MySqlCommand(sql, connection); // Сформировать готовый SQL-запрос на добавление в таблице tickets.
                command.Parameters.AddWithValue("@av", newTicket.Availability); // Присвоить значения параметров SQL-запросу
                command.Parameters.AddWithValue("@cost", newTicket.Cost);
                command.Parameters.AddWithValue("@pas", newTicket.Passenger_id);
                command.Parameters.AddWithValue("@review", newTicket.Review_id);
                command.Parameters.AddWithValue("@seat", newTicket.Seat_id);
                command.Parameters.AddWithValue("@route", newTicket.Route_id);

                command.ExecuteNonQuery(); // Выполнить SQL-запрос
                long localityId = command.LastInsertedId; // Узнать id объекта, который он получил в таблице БД
                newTicket.Id = localityId; // Присвоить этот id экземпляру этого объекта внутри приложения
                return newTicket; // Вернуть добавленный объект
            }
            catch (MySqlException exception) // Иначе... 
            {
                throw new RepositoryException(exception.ErrorCode, exception.Message); // Сообщить об ошибке
            }
        }

        public Ticket Update(Ticket ticket)
        {
            string sql = "UPDATE trains.tickets SET ticket_availability = @av, ticket_cost = @cost, passenger_id = @pas, review_id = @review, seat_id = @seat, route_id = @route WHERE idtickets = @id"; // Сформировать строку запроса на обновление в таблице tickets.

            using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД MySql

            connection.Open(); // Открыть соединение

            try // Попытаться...
            {
                using MySqlCommand command = new MySqlCommand(sql, connection); // Сформировать готовый SQL-запрос на обновление записи в таблице tickets.
                command.Parameters.AddWithValue("@av", ticket.Availability); // Присвоить значения параметров SQL-запросу
                command.Parameters.AddWithValue("@cost", ticket.Cost);
                command.Parameters.AddWithValue("@pas", ticket.Passenger_id);
                command.Parameters.AddWithValue("@review", ticket.Review_id);
                command.Parameters.AddWithValue("@seat", ticket.Seat_id);
                command.Parameters.AddWithValue("@route", ticket.Route_id);
                command.Parameters.AddWithValue("@id", ticket.Id);

                command.ExecuteNonQuery(); // Выполнить SQL-запрос.
                return ticket; // Вернуть обновлённый объект.
            }
            catch (MySqlException exception) // Иначе...
            {
                throw new RepositoryException(exception.ErrorCode, exception.Message); // Сообщить об ошибке.
            }
        }

        public void Delete(Ticket ticket)
        {
            try // Попытаться
            {
                string deleteTTS = "DELETE FROM trains.tickets_to_servcies WHERE ticket_id = @id"; // Сформировать строку запроса на удаление услуг, закреплённых за билетами.
                MySqlConnection connection = ConnectUtil.GetConnection();
                connection.Open(); // Открыть соединение.
                using MySqlCommand ttsCommand = new MySqlCommand(deleteTTS, connection); // Сформировать готовый запрос на удаление прикреплённых услуг.
                ttsCommand.Parameters.AddWithValue("@id", ticket.Id); // Присвоить значения переменной готовому SQL-запросу
                ttsCommand.ExecuteNonQuery(); // Выполнить запрос.

                connection.Close(); // Обновить соединение
                connection.Open();

                string query = "DELETE FROM trains.tickets WHERE idtickets = @id"; // Сформировать строку запроса на удаление записи о билете.
                using MySqlCommand command = new MySqlCommand(query, connection); // Сформировать готовый запрос на удаление записи о билете.
                command.Parameters.AddWithValue("@id", ticket.Id); // Присвоить значение переменной готовому SQL-запросу
                command.ExecuteNonQuery(); // Выполнить запрос.
            }
            catch (MySqlException ex) // Иначе...
            {
                throw new RepositoryException(ex.ErrorCode, ex.Message); // Сообщить об ошибке.
            }
        }

        public IEnumerable<Ticket> GetAll()
        {
            List<Ticket> tickets = new List<Ticket>(); // Считать, что изначально в БД нет билетов.
            string query = @"SELECT * FROM trains.tickets"; // Сформировать строку запроса на получение списка билетов.
            using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД.
            connection.Open(); // Открыть соединение
            try // Попытаться...
            {
                using MySqlCommand command = new MySqlCommand(query, connection); // Сформировать запрос на получение списка билетов.
                using MySqlDataReader reader = command.ExecuteReader();  // Выплнить запрос
                while (reader.Read()) // Пока имеются полученные объекты...
                {
                    long idTicket = reader.GetInt32(0); // Получить данные о билетах.
                    int availability = reader.GetInt32(1);
                    double cost = reader.GetDouble(2);
                    long review_id = reader.GetInt32(3);
                    long passenger_id = reader.GetInt32(4);
                    long seat_id = reader.GetInt32(5);
                    long route_id = reader.GetInt32(6);

                    tickets.Add(new Ticket(idTicket, availability, cost, review_id, passenger_id, seat_id, route_id)); // Добавить сформированные объекты билетов в коллекцию.
                }
                return tickets; // Вернуть коллекцию.
            }
            catch (MySqlException ex) // Иначе...
            {
                throw new RepositoryException(ex.ErrorCode, ex.Message); // Вывести исключение.
            }
        }

        public IEnumerable<Ticket> GetByPassenger(Passenger passenger)
        {
            List<Ticket> tickets = new List<Ticket>(); // Считать, что изначально в БД нет билетов у пассажира.
            string query = @"SELECT * FROM trains.tickets WHERE passenger_id = @id";
            using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД.
            connection.Open(); // Открыть соединение
            try // Попытаться...
            {
                using MySqlCommand command = new MySqlCommand(query, connection); // Сформировать запрос на получение списка билетов.
                command.Parameters.AddWithValue("@id", passenger.Id); // Присвоить значение переменной запросу.
                using MySqlDataReader reader = command.ExecuteReader();  // Выплнить запрос
                while (reader.Read()) // Пока имеются полученные объекты...
                {
                    long idTicket = reader.GetInt32(0); // Получить данные о билетах.
                    int availability = reader.GetInt32(1);
                    double cost = reader.GetDouble(2);
                    long review_id = reader.GetInt32(3);
                    long passenger_id = reader.GetInt32(4);
                    long seat_id = reader.GetInt32(5);
                    long route_id = reader.GetInt32(6);

                    tickets.Add(new Ticket(idTicket, availability, cost, review_id, passenger_id, seat_id, route_id)); // Добавить сформированные объекты билетов в коллекцию.
                }
                return tickets; // Вернуть коллекцию.
            }
            catch (MySqlException ex) // Иначе...
            {
                throw new RepositoryException(ex.ErrorCode, ex.Message); // Вывести исключение.
            }

        }

        public IEnumerable<Ticket> GetByTrainNumber(long trainNumber)
        {
            throw new NotImplementedException();
        }

        public Ticket GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
