using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class Capability : Entity
    {
        public string function { get; set; }
        public int AirConditionId { get; set; }
        
        public  virtual AirCondition AirCondition { get; set; }
    }
}