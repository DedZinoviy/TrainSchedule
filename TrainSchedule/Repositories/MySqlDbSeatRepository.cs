using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TrainSchedule.Conections;
using TrainSchedule.Models;
using TrainSchedule.RepositoryInterfaces;

namespace TrainSchedule.Repositories
{
    public class MySqlDbSeatRepository : ISeatRepository
    {
        public IEnumerable<Seat> GetFreeSeatByWagon(Wagon wagon)
        {
            var list = new List<Seat>(); // Считать, что изначально свободных мест в вагоне нет.
            string sql = @"SELECT * FROM trains.places
                           JOIN trains.wagons ON wagons.idwagons = places.wagon_id
                           WHERE idwagons = @id AND NOT idplaces IN (SELECT seat_id FROM trains.tickets)"; // Сформировать сторку запроса на поиск свободных мест в вагоне.
            MySqlConnection connection = ConnectUtil.GetConnection(); //Создать соединение с БД MySql.
            connection.Open(); // Открыть соединение.
            try // Попытаться...
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection); // Сформироваь готовый запрос на поиск свобоных мест в вагоне.
                cmd.Parameters.AddWithValue("@id", wagon.Id); // Присвоить параметру значение.
                MySqlDataReader reader = cmd.ExecuteReader(); // Выполнить запрос.
                while (reader.Read()) // Пока есть полученные элменты...
                {
                    long id = reader.GetInt32(0);
                    string type = reader.GetString(1);
                    int number = reader.GetInt32(2);
                    long wag_id = reader.GetInt32(3);
                    list.Add(new Seat(id, type, number, wag_id)); // Добавить элемент в коллекцию.
                }
                reader.Close(); // Закрыть соединение.
                connection.Close();
                return list; // Вернуть коллекцию.
            }
            catch (MySqlException ex) // Иначе...
            {
                throw new RepositoryException(ex.ErrorCode, ex.Message); // Сообщить об ошибке.
            }
            throw new NotImplementedException();
        }
    }
}
