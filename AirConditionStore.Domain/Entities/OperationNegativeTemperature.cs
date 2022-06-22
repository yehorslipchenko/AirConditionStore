using System.Collections.Generic;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class OperationNegativeTemperature : Entity
    {
        public OperationNegativeTemperature()
        {
            AirConditions = new HashSet<AirCondition>();
        }

        public int MinValueOfRange { get; set; }
        public int MaxValueOfRange { get; set; }
        
        public virtual ICollection<AirCondition> AirConditions { get; set; }
    }
}