using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;

namespace TrainSchedule.RepositoryInterfaces
{
    /// <summary>
    /// Interface for Seat repositories in databases.
    /// </summary>
    public interface ISeatRepository
    {
        /// <summary>
        /// Allows to get collection of vacant seats in wagon.
        /// </summary>
        /// <param name="wagon">A wagon for searching.</param>
        /// <returns>Collection of vacant seats.</returns>
        public IEnumerable<Seat> GetFreeSeatByWagon(Wagon wagon);
    }
}
