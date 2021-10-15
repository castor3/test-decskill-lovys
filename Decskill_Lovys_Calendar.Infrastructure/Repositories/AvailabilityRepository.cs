using System.Threading.Tasks;
using Decskill_Lovys_Calendar.Domain.Entities;
using Decskill_Lovys_Calendar.Domain.Repositories;

namespace Decskill_Lovys_Calendar.Infrastructure.Repositories
{
    public class AvailabilityRepository : IAvailabilityRepository
    {
        public Task<AvailabilityEntity> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Save(AvailabilityEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}