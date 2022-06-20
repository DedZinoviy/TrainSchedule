using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    /// <summary>
    /// Class for describing trains in databases.
    /// </summary>
    public class Train
    {
        /// <summary>
        /// Train ID.
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Train type
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// Train number.
        /// </summary>
        public long TrainNumber { get; set; }
        
        /// <summary>
        /// Express train flag.
        /// </summary>
        public bool IsExpressTrain { get; set; }

        /// <summary>
        /// Parametrized constructor.
        /// </summary>
        /// <param name="id">Id of train to be created.</param>
        /// <param name="type">Type of train to be created.</param>
        /// <param name="trainNumber">Number of train to be created.</param>
        /// <param name="isExpress">Express flag of train to be created.</param>
        public Train(long id, string type, long trainNumber, bool isExpress)
        {
            Id = id;
            Type = type;
            TrainNumber = trainNumber;
            IsExpressTrain = isExpress;
        }
    }
}
