using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule.Models
{
    /// <summary>
    /// Class for describing passengers.
    /// </summary>
    public class Passenger
    {
        /// <summary>
        /// Id of Passenger.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// First name of passenger.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of passenger.
        /// </summary>
        public string LastName { get; set;}

        /// <summary>
        /// Patronim of passenger.
        /// </summary>
        public string Patronim { get; set; }

        /// <summary>
        /// Contacts of passenger.
        /// </summary>
        public string Contacts { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="id">ID of passenger to be created.</param>
        /// <param name="firstName">First name of passenger to be created.</param>
        /// <param name="lastName">Last name of passenger to be created.</param>
        /// <param name="patronim">Patronim of passenger to be created.</param>
        /// <param name="contacts">Contacts of passenger to be created.</param>
        public Passenger(long id, string firstName, string lastName, string patronim, string contacts)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Patronim = patronim;
            Contacts = contacts;
        }
    }
}
