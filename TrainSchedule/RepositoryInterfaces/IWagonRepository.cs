using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;

namespace TrainSchedule.RepositoryInterfaces
{
    /// <summary>
    /// Interface for wagons repositories.
    /// </summary>
    public interface IWagonRepository
    {
        /// <summary>
        /// Allows to get collection of wagons related to train.
        /// </summary>
        /// <param name="train">Related train.</param>
        /// <returns>Collection of wagons.</returns>
        public IEnumerable<Wagon> GetByTrain(Train train);
    }
}
