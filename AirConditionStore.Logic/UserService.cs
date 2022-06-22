using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirConditionStore.DataAccess.Contracts;
using AirConditionStore.Domain.Constants;
using AirConditionStore.Domain.Entities;
using AirConditionStore.Logic.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AirConditionStore.Logic
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWorkFactory UnitOfWorkFactory;

        public UserService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            UnitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task CreateUserAsync(User user)
        {
            using (var uow = UnitOfWorkFactory.UnitOfWork)
            {
                var basicRole = uow.GetRepository<UserRole>().Query
                    .Single(x => x.NameAlias == UserRoleAliases.BasicRole);
                user.UserRole = basicRole;
                
                uow.GetRepository<UserInformation>().Create(user.Information);
                uow.GetRepository<User>().Create(user);

                await uow.SaveChangesAsync();
            }
        }

        public async Task<ICollection<User>> GetUsersAsync()
        {
            using (var uow = UnitOfWorkFactory.UnitOfWork)
            {
                return await uow.GetRepository<User>()
                    .Query
                    .Include(x => x.Information)
                    .ToListAsync();
            }
        }
        
        public async Task RemoveUser(string login)
        {
            using (var uow = UnitOfWorkFactory.UnitOfWork)
            {
                var item = uow.GetRepository<User>().Query.FirstOrDefault(x=> x.Login == login);

                if (item != default)
                {
                    uow.GetRepository<User>().Remove(item);
                    await uow.SaveChangesAsync();
                }
            }
        }
    }
}