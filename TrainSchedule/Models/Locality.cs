using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    /// <summary>
    /// Class for describing localities.
    /// </summary>
    public class Locality
    {
        ///<value>Id of Locality</value>
        public uint Id { get; set; }

        ///<value>Name of locality</value> 
        public string Name { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="id">Id of Locality to be created</param>
        /// <param name="name">Name of Locality to be created</param>
        public Locality(uint id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
