using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class OperatingMode : Entity
    {
        public string Mode { get; set; }
        public int AirConditionId { get; set; }
        
        public virtual AirCondition AirCondition { get; set; }
    }
}