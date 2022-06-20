using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    /// <summary>
    /// Class for describing routes in database.
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Route ID.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Related Train ID.
        /// </summary>
        public long TrainId { get; set; }

        /// <summary>
        /// Parametrized constructor
        /// </summary>
        /// <param name="id">Id of route to be created.</param>
        /// <param name="trainId">Related Train ID to be created.</param>
        public Route(long id, long trainId)
        {
            Id = id;
            TrainId = trainId;
        }
    }
}
