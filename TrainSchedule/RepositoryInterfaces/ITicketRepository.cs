using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;

namespace TrainSchedule.RepositoryInterfaces
{   
    /// <summary>
    /// Interface for Tickets repositoties.
    /// </summary>
    public interface ITicketRepository : IRepository<Ticket>
    {
        /// <summary>
        /// Allows to append new tickets in database table.
        /// </summary>
        /// <param name="newTicket">Ticket to be appended.</param>
        /// <returns>Appended ticket.</returns>
        public Ticket Append(Ticket newTicket);

        /// <summary>
        /// Allows to update tickets in database tables.
        /// </summary>
        /// <param name="ticket">Ticket to be updated.</param>
        /// <returns></returns>
        public Ticket Update(Ticket ticket);

        /// <summary>
        /// Allows to delete tickets from database table.
        /// </summary>
        /// <param name="ticket">Ticket to be deleted.</param>
        public void Delete(Ticket ticket);

        /// <summary>
        /// Returns collection of all tickets in database.
        /// </summary>
        /// <returns>Collection of all tickets in database.</returns>
        public IEnumerable<Ticket> GetAll();

        /// <summary>
        /// Returns collection of tickets releted to passenger.
        /// </summary>
        /// <param name="passenger">Passenger whose ticket collection is to be returned.</param>
        /// <returns>Collection of passenger's tickets.</returns>
        public IEnumerable<Ticket> GetByPassenger(Passenger passenger);

        /// <summary>
        /// Returns collection of tickets releted to train.
        /// </summary>
        /// <param name="trainNumber">Number of train whose ticket collection is to be returned.</param>
        /// <returns>Collection of train's tickets.</returns>
        public IEnumerable<Ticket> GetByTrainNumber(long trainNumber);
    }
}
