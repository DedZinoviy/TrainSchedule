using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;

namespace TrainSchedule.RepositoryInterfaces
{
    /// <summary>
    /// Interface for Locality repositories.
    /// </summary>
    interface ILocalityRepository : IRepository<Locality>
    {
        /// <summary>
        /// Allows to get locality object by its name.
        /// </summary>
        /// <param name="name">Name of locality to get.</param>
        /// <returns>Locality recieved object.</returns>
        public Locality getByName(string name);

        /// <summary>
        /// Allows to update locality object in database.
        /// </summary>
        /// <param name="locality">Locality object to update.</param>
        /// <returns>Updated locality object.</returns>
        public Locality update(Locality locality);

        /// <summary>
        /// Allows to append new locality object in database.
        /// </summary>
        /// <param name="newLocality">Locality object to append.</param>
        /// <returns>Appended locality object</returns>
        public Locality append(Locality newLocality);

        /// <summary>
        /// Allows to delete locality object in database.
        /// </summary>
        /// <param name="locality">Locality object to delete.</param>
        public void delete(Locality locality);
    }
}
