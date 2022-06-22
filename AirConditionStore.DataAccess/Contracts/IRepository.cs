using System.Linq;
using System.Threading.Tasks;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.DataAccess.Contracts
{
    public interface IRepository<T> where T : Entity
    {
        void Create(T item);
        Task<T> FindById(int id);
        IQueryable<T> Query { get; }
        void Remove(T item);
        void Update(T item);
        void AddOrUpdate(T item);
    }
}