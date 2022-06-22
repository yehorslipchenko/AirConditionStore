using AirConditionStore.DataAccess.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace AirConditionStore.DataAccess.Extensions
{
    public static class DataAccessDIExtensions
    {
        public static void RegisterDataAccessDI(this IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWorkFactory, UnitOfWorkFactory>();
        }
    }
}