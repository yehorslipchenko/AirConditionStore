using System.Collections.Generic;
using System.Threading.Tasks;
using AirConditionStore.DataAccess.Contracts;
using AirConditionStore.Domain.Entities;
using AirConditionStore.Logic.Contracts;
using Microsoft.EntityFrameworkCore;

namespace AirConditionStore.Logic
{
    public class AirConditionService : IAirConditionService
    {
        private readonly IUnitOfWorkFactory UnitOfWorkFactory;

        public AirConditionService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            UnitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task CreateAirConditionAsync(AirCondition airCondition)
        {
            using (var uow = UnitOfWorkFactory.UnitOfWork) 
            {
                uow.GetRepository<AirCondition>().Create(airCondition);

                await uow.SaveChangesAsync();
            }
        }

        public async Task<ICollection<AirCondition>> GetAirConditionAsync()
        {
            using (var uow = UnitOfWorkFactory.UnitOfWork)
            {
                return await uow.GetRepository<AirCondition>()
                    .Query
                    .Include(x => x.Brand)
                    .Include(x => x.Capabilities)
                    .Include(x=> x.Countries)
                    .Include(x=> x.Modes)
                    .Include(x=> x.Status)
                    .Include(x=> x.ControlTypes)
                    .Include(x => x.OperationNegative)
                    .Include(x=> x.AirConditionType)
                    .Include(x=> x.IndoorUnitInstallationType)
                    .ToListAsync();
            }
        }
    }
}