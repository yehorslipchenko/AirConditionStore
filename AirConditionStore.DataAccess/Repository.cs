using System.Linq;
using System.Threading.Tasks;
using AirConditionStore.DataAccess.Contracts;
using AirConditionStore.Domain.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AirConditionStore.DataAccess
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly AirConditionStoreContext context;
        private readonly DbSet<T> dbSet;

        public Repository(AirConditionStoreContext _context)
        {
            context = _context;
            dbSet = context.Set<T>();
        }

        public void Create(T item)
        {
            dbSet.Add(item);
        }

        public async Task<T> FindById(int id)
        {
            return await dbSet.SingleAsync(x => x.Id == id);
        }

        public IQueryable<T> Query { get { return dbSet; } }

        public void Remove(T item)
        {
            dbSet.Remove(item);
        }

        public void Update(T item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void AddOrUpdate(T item)
        {
            if (item.Id == default)
            {
                Create(item);
            }
            else
            {
                Update(item);
            }
        }
    }
}