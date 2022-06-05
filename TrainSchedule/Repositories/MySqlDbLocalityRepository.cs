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
        public Locality append(Locality newLocality)
        {
            throw new NotImplementedException();
        }

        public Locality update(Locality locality)
        {
            throw new NotImplementedException();
        }

        public Locality getByName(string name)
        {
            throw new NotSupportedException();
        }

        public void delete(Locality locality)
        {

        }

        public Locality getById(uint id)
        {
            throw new NotImplementedException();
        }
    }
}
