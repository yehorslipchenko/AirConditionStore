using System.Collections.Generic;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class Compressor : Entity
    {
        public Compressor()
        {
            AirConditions = new HashSet<AirCondition>();
        }

        public string CompressorType { get; set; }
        
        public virtual ICollection<AirCondition> AirConditions { get; set; }
    }
}