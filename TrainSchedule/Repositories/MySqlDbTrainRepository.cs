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
    }
}
