using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;
using TrainSchedule.Repositories;
using TrainSchedule.RepositoryInterfaces;
using TrainSchedule.Conections;
using MySql.Data.MySqlClient;

namespace TrainSchedule.Services
{
    /// <summary>
    /// Class for operations with tickets in different tables.
    /// </summary>
    public class DbTicketServices
    {
        /// <summary>
        /// Implementeation of ticket repository.
        /// </summary>
        private ITicketRepository ticketRepository;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DbTicketServices()
        {
            ticketRepository = new MySqlDbTicketRepository();
        }

        /// <summary>
        /// Allows to get collection of passenger's tickets and info about them.
        /// </summary>
        /// <param name="passenger">The passenger who purchased the tickets.</param>
        /// <param name="trains">Trains for which tickets have been purchased.</param>
        /// <param name="Locs">The localities from where trains depart.</param>
        /// <param name="dateTimesArr">Time of trains arrival to localities.</param>
        /// <param name="dateTimesDep">Time of trains departure from localities.</param>
        /// <returns>Collection of passenger's tickets.</returns>
        /// <exception cref="RepositoryException">Exceptions in database.</exception>
        public IEnumerable<Ticket> GetInfoAboutTicketsByPassenger(Passenger passenger, out IEnumerable<Train> trains, out IEnumerable<Locality> Locs, out IEnumerable<DateTime> dateTimesArr, out IEnumerable<DateTime> dateTimesDep)
        {
            try // Попытаться...
            {
                // Получить список билетов заданного пассажира.
                IEnumerable<Ticket> ticketCollection = ticketRepository.GetByPassenger(passenger);

                // Сформировать строку запроса на получение информации по билету.
                string trainSql = @"SELECT idtrains, type_of_train, number_of_train, is_express_train, idlocalities, name_of_locality, date_time_of_arrival, date_time_of_departure FROM trains.trains
                                JOIN trains.routes ON routes.train_id = trains.idtrains
                                JOIN trains.tickets ON tickets.route_id = routes.id_routes
                                JOIN routes_to_stations AS rts ON rts.route_id = routes.id_routes
                                JOIN stations ON idstations = rts.station_id
                                JOIN localities ON localities.idlocalities = stations.locality_id
                                WHERE tickets.idtickets = @id";
                MySqlConnection connection = ConnectUtil.GetConnection(); // Созздать соединение с БД.
                connection.Open(); // Открыть соединение.
                MySqlCommand command = new MySqlCommand(trainSql, connection); // Сформировать команду SQL-запроса.
                List<Train> trainsList = new List<Train>();
                List<Locality> arr = new List<Locality>();
                List<DateTime> depTime = new List<DateTime>();
                List<DateTime> arrTime = new List<DateTime>();
                foreach (var ticket in ticketCollection) // Для каждого билета...
                {
                    command.Parameters.AddWithValue("@id",ticket.Id); // Добавить параметр в переменную
                    using MySqlDataReader reader = command.ExecuteReader(); // Считать объект из БД.
                    if (reader.Read())
                    {
                        long idTrain = reader.GetInt32(0);
                        string type = reader.GetString(1);
                        long number = reader.GetInt32(2);
                        bool isExpress = reader.GetBoolean(3);
                        long idLoc = reader.GetInt32(4);
                        string nameOfLoc = reader.GetString(5);
                        DateTime dateTime1 = reader.GetDateTime(6);
                        DateTime dateTime2 = reader.GetDateTime(7);
                        trainsList.Add(new Train(idTrain, type, number, isExpress));
                        arr.Add(new Locality(idLoc, nameOfLoc));
                        arrTime.Add(dateTime1);
                        depTime.Add(dateTime2);

                    }
                }
                // Вернуть колеекцию биетов и доп. информацию.
                trains = trainsList;
                Locs = arr;
                dateTimesArr = arrTime;
                dateTimesDep = depTime;
                return ticketCollection;            
            }
            catch (MySqlException ex) // Иначе...
            {
                throw new RepositoryException(ex.ErrorCode, ex.Message); // Сообщить об ошибке.
            }
        }

        /// <summary>
        /// Delete tickets from Tickets table.
        /// </summary>
        /// <param name="idTicket">Tickets's id</param>
        /// <returns>Success of operation</returns>
        public int DeletePassenger(long idTicket)
        {
            Ticket ticket = new Ticket(idTicket, 0, 0, 0, 0, 0, 0);
            // Попытаться...
            try
            {
                // Удалить билет по id.
                ticketRepository.Delete(ticket);

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
    }
}
