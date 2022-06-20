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
    }
}
