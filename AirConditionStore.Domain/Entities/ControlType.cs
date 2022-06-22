using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class ControlType : Entity
    {
        public string Control { get; set; }
        public int AirConditionId { get; set; }
        
        public virtual AirCondition AirCondition { get; set; }
    }
}