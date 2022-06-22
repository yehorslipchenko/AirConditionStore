using System.Collections.Generic;
using System.Threading.Tasks;
using AirConditionStore.Domain.Entities;

namespace AirConditionStore.Logic.Contracts
{
    public interface IAirConditionService
    {
        Task CreateAirConditionAsync(AirCondition airCondition);
        Task<ICollection<AirCondition>> GetAirConditionAsync();
    }
}