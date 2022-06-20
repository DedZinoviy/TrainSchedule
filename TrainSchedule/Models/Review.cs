using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    /// <summary>
    /// Class for describing reviews.
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Review's ID
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Review's title 
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Review's description (text)
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Review's evaluation.
        /// </summary>
        public float Evaluation { get; set; }

        /// <summary>
        /// Parametrized constructor.
        /// </summary>
        /// <param name="id">Id of review to be created.</param>
        /// <param name="name">Name of review to be created.</param>
        /// <param name="descript">Description of review to be created.</param>
        /// <param name="eval">Evaluation of review to be created.</param>
        public Review(long id, string name, string descript, float eval)
        {
            Id = id;
            Name = name;
            Description = descript;
            Evaluation = eval;
        }
    }
}
