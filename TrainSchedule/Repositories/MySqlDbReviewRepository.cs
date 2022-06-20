using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.RepositoryInterfaces;
using TrainSchedule.Models;

namespace TrainSchedule.Repositories
{
    public class MySqlDbReviewRepository : IReviewRepository
    {

        public Review Append(Review newReview)
        {
            throw new NotImplementedException();
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
