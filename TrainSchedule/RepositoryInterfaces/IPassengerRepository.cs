using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;

namespace TrainSchedule.RepositoryInterfaces
{
    /// <summary>
    /// Interface for Passenger repositories.
    /// </summary>
    public interface IPassengerRepository : IRepository<Passenger>
    {
        /// <summary>
        /// Allows to update passsenger object in database.
        /// </summary>
        /// <param name="passenger">Passenger object to update.</param>
        /// <returns>Updated passenger object.</returns>
        public Passenger Update(Passenger passenger);

        /// <summary>
        /// Allows to append new passenger object in database.
        /// </summary>
        /// <param name="newPassenger">Passenger object to append.</param>
        /// <returns>Appended Passenger object</returns>
        public Passenger Append(Passenger newPassenger);

        /// <summary>
        /// Allows to delete Passenger object in database.
        /// </summary>
        /// <param name="passenger">Passenger object to delete.</param>
        public void Delete(Passenger passenger);

        /// <summary>
        /// Allows to get all passengers in database.
        /// </summary>
        /// <returns>Collection of passengers.</returns>
        public IEnumerable<Passenger> GetAll();
    }
}
