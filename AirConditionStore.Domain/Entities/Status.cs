using System.Collections.Generic;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class Status : Entity
    {
        public Status()
        {
            AirConditions = new HashSet<AirCondition>();
        }

        public string Type { get; set; }

        public virtual ICollection<AirCondition> AirConditions { get; set; }
    }
}