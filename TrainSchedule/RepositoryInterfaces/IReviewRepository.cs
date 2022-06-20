using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;

namespace TrainSchedule.RepositoryInterfaces
{
    /// <summary>
    /// Interface for review repositories.
    /// </summary>
    public interface IReviewRepository
    {
        /// <summary>
        /// Allows to append reviews in database.
        /// </summary>
        /// <param name="newReview">Review to be appended.</param>
        /// <returns>Appended review.</returns>
        public Review Append(Review newReview);
        
        /// <summary>
        /// Allows to update reviews in database.
        /// </summary>
        /// <param name="review">Review to be updated.</param>
        /// <returns>Updated review.</returns>
        public Review Update(Review review);

        /// <summary>
        /// Allows to delete reviews from database.
        /// </summary>
        /// <param name="review">Review to delete.</param>
        public void Delete(Review review);
        
        /// <summary>
        /// Allows to get review from database by related ticket.
        /// </summary>
        /// <param name="ticket">Related ticket.</param>
        /// <returns>Recieved review.</returns>
        public Review GetByTicket(Ticket ticket);

        /// <summary>
        /// Allowsto get average evaluation of routes by trains.
        /// </summary>
        /// <param name="train">Train to be evaluated.</param>
        /// <returns>Evaluation.</returns>
        public float GetAverageEvaluationByTrain(Train train);
    }
}
