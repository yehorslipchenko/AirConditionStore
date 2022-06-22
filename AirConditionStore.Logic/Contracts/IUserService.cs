using System.Collections.Generic;
using System.Threading.Tasks;
using AirConditionStore.Domain.Entities;

namespace AirConditionStore.Logic.Contracts
{
    public interface IUserService
    {
        Task CreateUserAsync(User user);
        Task<ICollection<User>> GetUsersAsync();
    }
}