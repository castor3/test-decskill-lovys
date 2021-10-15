using System.Threading.Tasks;

namespace Decskill_Lovys_Calendar.Domain.Repositories
{
    public interface IRepository<T>
    {
        Task<T> Get(int id);
        
        Task Save(T entity);

        Task Delete(int id);
    }
}