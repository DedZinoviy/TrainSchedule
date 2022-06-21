using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TrainSchedule.Repositories;
using TrainSchedule.Models;
using TrainSchedule.RepositoryInterfaces;
using TrainSchedule.Conections;

namespace TrainSchedule.Services
{
    public class DbReviewService
    {
        private IReviewRepository rep;
        public DbReviewService()
        {
            rep = new MySqlDbReviewRepository();
        }

        public Review AppendNewReview(string name, string message, float evaluation, out int error)
        {
            // Создать временный объект для добавления в БД
            Review newRev = new Review(0, name, message, evaluation);

            // Попытаться...
            try
            {
                // Добавить новый отзыв
                newRev = rep.Append(newRev);
                error = 0;

                // Вернуть добавленный объект отзыва.
                return newRev;
            }
            // Иначе...
            catch (RepositoryException ex)
            {
                // Вернуть исключение.
                error = ex.ErrorCode;
                return null;
                throw ex;
            }
        }

        public Review UpdateReview(long id, string name, string message, float evaluation)
        {
            Review rev = new Review(id, name, message, evaluation);
            // Попытаться...
            try
            {
                // Обновить данные в таблице БД об отзыве.
                rev = rep.Update(rev);

                // Вернуть результат операции.
                return rev;
            }
            // Иначе...
            catch (RepositoryException ex)
            {
                // Сообщить об ошибке.
                throw ex;
            }
        }
    }
}
