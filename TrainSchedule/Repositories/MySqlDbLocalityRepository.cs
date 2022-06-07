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
    public class MySqlDbLocalityRepository : ILocalityRepository
    {
        public Locality Append(Locality newLocality)
        {
            string sql = "INSERT INTO trains.localities (name_of_locality) VALUES @name_of_loc"; // Сформировать строку SQL-запроса на добавление данных в таблицу localities

            using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД MySql

            connection.Open(); // Открыть соединение

            try // Попытаться...
            {
                using MySqlCommand command = new MySqlCommand(sql, connection); // Сформировать готовый SQL-запрос на добавление в таблицу localities
                command.Parameters.AddWithValue("@name_of_loc", newLocality.Name); // Присвоить значения параметров SQL-запросу
                command.ExecuteNonQuery(); // Выполнить SQL-запрос
                long localityId = command.LastInsertedId; // Узнать id объекта, который он получил в таблице БД
                newLocality.Id = localityId; // Присвоить этот id экземпляру этого объекта внутри приложения
                return newLocality; // Вернуть добавленный объект
            }
            catch (MySqlException exception) // Иначе... 
            {
                throw new RepositoryException(exception.ErrorCode, exception.Message); // Сообщить об ошибке
            }
        }

        public Locality Update(Locality locality)
        {
            throw new NotImplementedException();
        }

        public Locality GetByName(string name)
        {
            throw new NotSupportedException();
        }

        public void Delete(Locality locality)
        {

        }

        public Locality GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
