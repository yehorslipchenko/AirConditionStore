using System.Collections.Generic;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class IndoorUnitInstallationType : Entity
    {
        public IndoorUnitInstallationType()
        {
            AirConditions = new HashSet<AirCondition>();
        }

        public string InstallationType { get; set; }
        
        public virtual ICollection<AirCondition> AirConditions { get; set; }
    }
}