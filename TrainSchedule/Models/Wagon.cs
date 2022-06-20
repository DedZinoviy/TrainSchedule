using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    /// <summary>
    /// Class for describing wagons.
    /// </summary>
    public class Wagon
    {
        /// <summary>
        /// Wagon's id.
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Wagon's type.
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// Number Of Wagon.
        /// </summary>
        public int Number { get; set; }
        
        /// <summary>
        /// Parametrized Constructor
        /// </summary>
        /// <param name="id">Id of wagon to be created.</param>
        /// <param name="type">Type of wagon to be created.</param>
        /// <param name="number">Number of wagon to be created.</param>
        public Wagon(long id, string type, int number)
        {
            Id = id;
            Type = type;
            Number = number;
        }
    }
}
