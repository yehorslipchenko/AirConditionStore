using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public UserInformation Information { get; set; }
        public int UserRoleId { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}