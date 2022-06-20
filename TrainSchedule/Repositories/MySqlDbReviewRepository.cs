using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TrainSchedule.Conections;
using TrainSchedule.RepositoryInterfaces;
using TrainSchedule.Models;

namespace TrainSchedule.Repositories
{
    public class MySqlDbReviewRepository : IReviewRepository
    {

        public Review Append(Review newReview)
        {
            string sql = "INSERT INTO trains.reviews (review_name,evaluation,comment) VALUES (@r_name, @ev, @com)"; // Сформировать строку SQL-запроса на добавление данных в таблицу reviews

            using MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соединение с БД MySql

            connection.Open(); // Открыть соединение

            try // Попытаться...
            {
                using MySqlCommand command = new MySqlCommand(sql, connection); // Сформировать готовый SQL-запрос на добавление в таблице reviews.
                command.Parameters.AddWithValue("@r_name", newReview.Name); // Присвоить значения параметров SQL-запросу
                command.Parameters.AddWithValue("@ev", newReview.Evaluation);
                command.Parameters.AddWithValue("@com", newReview.Description);

                command.ExecuteNonQuery(); // Выполнить SQL-запрос
                long localityId = command.LastInsertedId; // Узнать id объекта, который он получил в таблице БД
                newReview.Id = localityId; // Присвоить этот id экземпляру этого объекта внутри приложения
                return newReview; // Вернуть добавленный объект
            }
            catch (MySqlException exception) // Иначе... 
            {
                throw new RepositoryException(exception.ErrorCode, exception.Message); // Сообщить об ошибке
            }
        }


        public Review Update(Review review)
        {
            throw new NotImplementedException();
        }


        public void Delete(Review review)
        {
            throw new NotImplementedException();
        }


        public Review GetByTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }


        public float GetAverageEvaluationByTrain(Train train)
        {
            throw new NotImplementedException();
        }
    }
}
