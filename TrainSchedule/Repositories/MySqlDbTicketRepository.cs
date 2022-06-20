﻿using System;
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
            throw new NotImplementedException();
        }

        public Ticket Update(Ticket ticket)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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