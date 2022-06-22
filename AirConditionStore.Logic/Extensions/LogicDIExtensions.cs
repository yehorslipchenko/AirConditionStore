using AirConditionStore.Logic.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace AirConditionStore.Logic.Extensions
{
    public static class LogicDIExtensions
    {
        public static void RegisterLogicDI(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAirConditionService, AirConditionService>();
        }
        
    }
}