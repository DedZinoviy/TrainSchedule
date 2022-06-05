using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule.RepositoryInterfaces
{
    /// <summary>
    /// Interface for repositories
    /// </summary>
    /// <typeparam name="T">Data type to create repository for</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Allows get object by ID
        /// </summary>
        /// <param name="id">ID of object to get</param>
        /// <returns>Recieved object</returns>
        T getById(uint id);
    }
}
