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
            string sql = "SELECT * FROM trains.reviews WHERE idreviews = @id"; // Сформировать строку на получение отзыва по билету.
            MySqlConnection connection = ConnectUtil.GetConnection(); //Создать соединение с MySql.
            connection.Open(); //Открыть соединение.
            try // Попытаться...
            {
                MySqlCommand command = new MySqlCommand(sql, connection); // Сформировать готовый запрос на получение отзыва по билету.
                command.Parameters.AddWithValue("@id", ticket.Review_id); // Присвоить значения параметрам.
                using MySqlDataReader reader = command.ExecuteReader(); // Выполнить запрос.
                if (reader.Read()) // Пока есть элементы...
                {
                    long id = reader.GetInt32(0); // Получить данные.
                    string name = reader.GetString(1);
                    string comment = reader.GetString(2);
                    float rating = reader.GetFloat(3);
                    return new Review(id, name, comment, rating); // Вернуть объект отзыва
                }
                return null;
            }
            catch (MySqlException exception) // Иначе...
            {
                throw new RepositoryException(exception.ErrorCode, exception.Message); // Сообщить об ошибке.
            }
        }


        public float GetAverageEvaluationByTrain(Train train)
        {
            string sql = @"SELECT AVG(rv.evaluation) FROM trains.reviews AS rv
                            RIGHT JOIN trains.tickets AS tct ON rv.idreviews = tct.review_id
                            RIGHT JOIN trains.routes AS r ON r.id_routes = tct.route_id
                            JOIN trains.trains AS t ON t.idtrains = r.train_id
                            WHERE t.number_of_train = @number"; // Сформировать запрос на получение средней пассажирской оценки.
            MySqlConnection connection = ConnectUtil.GetConnection(); // Создать соедение с БД MySql.
            connection.Open();//Открыть соединение.
            try // Попытаться...
            {
                MySqlCommand cmd = new MySqlCommand(sql,connection); // Сформирвоать готовый запрос.
                cmd.Parameters.AddWithValue("@number", train.TrainNumber); //Присвоить значения параметрам.
                using MySqlDataReader reader = cmd.ExecuteReader(); // Выполнить запрос.
                if(reader.Read()) // Вернуть среднюю оценку, если таковая получена.
                {
                    return reader.GetFloat(0);
                }
                return 0;
            }
            catch (MySqlException exception) //Иначе...
            {
                throw new RepositoryException(exception.ErrorCode, exception.Message); // сообщить об ошибке.
            }
        }
    }
}
