using System;
using System.Threading.Tasks;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.DataAccess.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        bool IsDisposed { get; }
        Task SaveChangesAsync();
        IRepository<T> GetRepository<T>() where T : Entity;
    }
}