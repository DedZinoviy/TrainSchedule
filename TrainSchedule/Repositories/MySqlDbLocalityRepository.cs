using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainSchedule.Models;
using TrainSchedule.RepositoryInterfaces;

namespace TrainSchedule.Repositories
{
    public class MySqlDbLocalityRepository : ILocalityRepository
    {
        public Locality Append(Locality newLocality)
        {
            throw new NotImplementedException();
        }

        public Locality Update(Locality locality)
        {
            throw new NotImplementedException();
        }

        public Locality GetByName(string name)
        {
            throw new NotSupportedException();
        }

        public void Delete(Locality locality)
        {

        }

        public Locality GetById(uint id)
        {
            throw new NotImplementedException();
        }
    }
}
