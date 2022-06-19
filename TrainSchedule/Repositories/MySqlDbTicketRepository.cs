using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;
using TrainSchedule.RepositoryInterfaces;

namespace TrainSchedule.Repositories
{
    public class MySqlDbTicketRepository : ITicketRepository
    {
        public Ticket Append(Ticket newTicket)
        {
            throw new NotImplementedException();
        }

        public Ticket Update(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void Delete(Ticket ticket)
        {

        }

        public IEnumerable<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetByPassenger(Passenger passenger)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetByTrainNumber(long trainNumber)
        {
            throw new NotImplementedException();
        }

        public Ticket GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
