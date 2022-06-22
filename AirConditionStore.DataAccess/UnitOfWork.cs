using System.Threading.Tasks;
using AirConditionStore.DataAccess.Contracts;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AirConditionStoreContext context;
        private bool disposed = false;
        
        public bool IsDisposed { get { return disposed; } }

        public UnitOfWork(AirConditionStoreContext _context)
        {
            context = _context;
        }
        
        public IRepository<T> GetRepository<T>() where T : Entity
        {
            return new Repository<T>(context);
        }
        public void Dispose() => Dispose(true);
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                context.Dispose();
            }

            disposed = true;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        ~UnitOfWork()
        {
            Dispose();
        }
    }
}