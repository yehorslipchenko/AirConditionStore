using System.Collections.Generic;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class Brand : Entity
    {
        public Brand()
        {
            AirConditions = new HashSet<AirCondition>();
        }
        
        public string Name { get; set; }

        public virtual ICollection<AirCondition> AirConditions { get; set; }
    }
}