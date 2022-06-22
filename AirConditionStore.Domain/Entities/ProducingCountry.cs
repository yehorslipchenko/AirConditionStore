using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class ProducingCountry : Entity
    {
        public string Country { get; set; }
        public int AirConditionId { get; set; }
        
        public virtual AirCondition AirCondition { get; set; }
    }
}