using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class UserInformation : Entity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}