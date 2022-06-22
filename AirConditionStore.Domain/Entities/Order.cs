using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class Order : Entity
    {
        public int UserId { get; set; }

        public int AirConditionId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
        public virtual AirCondition AirCondition { get; set; }
    }
}