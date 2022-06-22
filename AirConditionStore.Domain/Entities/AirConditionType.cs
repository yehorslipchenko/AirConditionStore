using System.Collections.Generic;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class AirConditionType : Entity
    {
        public AirConditionType()
        {
            AirConditions = new HashSet<AirCondition>();
        }

        public string Type { get; set; }

        public virtual ICollection<AirCondition> AirConditions { get; set; }
    }
}