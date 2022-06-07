using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;

namespace TrainSchedule.RepositoryInterfaces
{
    public interface IPassengerRepository
    {
        /// <summary>
        /// Interface for Locality repositories.
        /// </summary>
        interface ILocalityRepository : IRepository<Passenger>
        {
            /// <summary>
            /// Allows to update locality object in database.
            /// </summary>
            /// <param name="locality">Locality object to update.</param>
            /// <returns>Updated locality object.</returns>
            public Locality Update(Locality locality);

            /// <summary>
            /// Allows to append new locality object in database.
            /// </summary>
            /// <param name="newLocality">Locality object to append.</param>
            /// <returns>Appended locality object</returns>
            public Locality Append(Locality newLocality);

            /// <summary>
            /// Allows to delete locality object in database.
            /// </summary>
            /// <param name="locality">Locality object to delete.</param>
            public void Delete(Locality locality);
        }
    }
}
