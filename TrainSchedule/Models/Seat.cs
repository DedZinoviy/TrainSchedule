using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    /// <summary>
    /// Class for describing seats (places) in database.
    /// </summary>
    public class Seat
    {
        /// <summary>
        /// Seat's ID.
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Seat's type.
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// Seat's number.
        /// </summary>
        public int Number { get; set; }
        
        /// <summary>
        /// Wagon id where seat placed.
        /// </summary>
        public long WagonId { get; set; }

        /// <summary>
        /// Parametrized constructor.
        /// </summary>
        /// <param name="id">Id of seat to be created.</param>
        /// <param name="type">Type of seat to be created.</param>
        /// <param name="num">Number of seat t be created.</param>
        /// <param name="wag_id">Id of wagon where seat is placed.</param>
        public Seat(long id, string type, int num, long wag_id)
        {
            Id = id;
            Type = type;
            Number = num;
            WagonId = wag_id;
        }
    }
}
