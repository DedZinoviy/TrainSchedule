using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;

namespace TrainSchedule.RepositoryInterfaces
{
    /// <summary>
    /// Interface for Trains repositories
    /// </summary>
    public interface ITrainRepository
    {
        /// <summary>
        /// Allows to get all Train objects in database.
        /// </summary>
        /// <returns>Collection of trains.</returns>
        public IEnumerable<Train> GetAll();

        /// <summary>
        /// Allows to get info about number of wagons and number of places in train.
        /// </summary>
        /// <param name="train"></param>
        /// <param name="placesNumber"></param>
        /// <returns></returns>
        public int GetInfoAboutWagonsAndPlaces(Train train, out int placesNumber);
    }
}
