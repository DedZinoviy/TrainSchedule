using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;
using TrainSchedule.RepositoryInterfaces;
using TrainSchedule.Conections;
using MySql.Data.MySqlClient;

namespace TrainSchedule.Repositories
{
    public class MySqlDbTrainRepository : ITrainRepository
    {
        public IEnumerable<Train> GetAll()
        {
            List<Train> list = new List<Train>(); // Считать, что изначально в БД нетобъектов поездов.
            string sql = "SELECT * FROM trains.trains"; // Сформировать строук запроса на получение всех объектов поездов.
            MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД MySql.
            connection.Open(); // Открыть соединение.
            try // Попытаться...
            {
                MySqlCommand command = new MySqlCommand(sql, connection); // Сформировать готовый запрос Sql.
                using MySqlDataReader reader = command.ExecuteReader();  // Выплнить запрос
                while (reader.Read()) // Пока имеются полученные объекты...
                {
                    long idTrain = reader.GetInt32(0); // Получить данные о поездах.
                    string type = reader.GetString(1);
                    long trainNumber = reader.GetInt32(2);
                    bool isExpress = reader.GetBoolean(3);
                    list.Add(new Train(idTrain, type, trainNumber, isExpress)); // Добавить сформированные объекты поездов в коллекцию.
                }
                return list; // Вернуть коллекцию.
            }
            catch (MySqlException ex) // Иначе...
            {
                throw new RepositoryException(ex.ErrorCode, ex.Message); //Сообщить об ошибке.
            }
        }

        public int GetInfoAboutWagonsAndPlaces(Train train, out int placesNumber)
        {
            string wagonCount = @"SELECT COUNT(wagon_id) FROM trains.trains_to_wagons As ttw
            JOIN trains.trains AS t ON t.idtrains = ttw.train_id
            WHERE t.number_of_train = @num"; //Сформировать строку на запроса на получение количества вагонов.

            string wagonIds = @"SELECT wagon_id FROM trains.trains_to_wagons As ttw
            JOIN trains.trains AS t ON t.idtrains = ttw.train_id
            WHERE t.number_of_train = @num"; // Сформировать строку на получение id вагонов.

            List<long> ids = new List<long>();
            List<int> places = new List<int>();

            MySqlConnection con = ConnectUtil.GetConnection(); // Создать соединение с БД.
            con.Open(); // Открыть соединение
            try // Попытаться...
            {
                // Полцчить список вагонов
                MySqlCommand cmd = new MySqlCommand(wagonIds, con);
                cmd.Parameters.AddWithValue("@num", train.TrainNumber);
                using MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    ids.Add(reader.GetInt32(0));
                }
                reader.Close();
                con.Close();
                con.Open();

                // Получить количество мест.
                string placeNumber = @"SELECT COUNT(wagon_id) FROM trains.places WHERE wagon_id = @id";

                foreach (long id in ids)
                {
                    cmd = new MySqlCommand(placeNumber, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    using MySqlDataReader newReader = cmd.ExecuteReader();
                    if(newReader.Read())
                    {
                        places.Add(newReader.GetInt32(0));
                    }
                }

                placesNumber = places.Sum();

                // Получить количесво вагонов.
                cmd = new MySqlCommand(wagonCount, con);
                cmd.Parameters.AddWithValue("@num", train.TrainNumber);
                using MySqlDataReader countReader = cmd.ExecuteReader();
                if(countReader.Read())
                {
                    return countReader.GetInt32(0);
                }
                return 0;
            }
            catch (Exception ex) // Иначе...
            {
                throw ex; //сообщить об ошибке.
            }
        }
    }
}
