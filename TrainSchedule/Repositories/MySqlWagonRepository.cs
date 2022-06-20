using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TrainSchedule.Models;
using TrainSchedule.Conections;
using TrainSchedule.RepositoryInterfaces;

namespace TrainSchedule.Repositories
{
    public class MySqlWagonRepository : IWagonRepository
    {
        public IEnumerable<Wagon> GetByTrain(Train train)
        {
            List<Wagon> wagonList = null; // Считать, что изначально у поезда нет вагонов.
            string sql = @"SELECT idwagons, number_of_wagon, type_of_wagon FROM trains.wagons
                           JOIN trains.trains_to_wagons AS ttw ON ttw.wagon_id = wagons.idwagons
                           JOIN trains.trains ON trains.idtrains = ttw.train_id
                           WHERE trains.idtrains = @id"; // Сформировать строку запроса на получение списка вагонов поезда.
            
            MySqlConnection connection = ConnectUtil.GetConnection(); // Создать подключение к БД MySql.
            connection.Open(); // Открыть соединение.

            try // Попытаться...
            {
                MySqlCommand command = new MySqlCommand(sql, connection); // Сформировать готовый запрос на получение списка вагонов.
                command.Parameters.AddWithValue("@id", train.Id); // Присвоить значения параметров SQL-запросу.
                using MySqlDataReader reader = command.ExecuteReader();  // Выплнить запрос
                while (reader.Read()) // Пока имеются полученные объекты...
                {
                    long idWagon = reader.GetInt32(0); // Получить данные о вагонах.
                    string type = reader.GetString(1);
                    int number = reader.GetInt32(2);

                    wagonList.Add(new Wagon(idWagon, type, number)); // Добавить сформированные объекты вагонов в коллекцию.
                }
                return wagonList; // Вернуть коллекцию.
            }
            catch (MySqlException ex) // Иначе...
            {
                throw new RepositoryException(ex.ErrorCode, ex.Message); // Сообщить об ошибке.
            }              
        }
    }
}
