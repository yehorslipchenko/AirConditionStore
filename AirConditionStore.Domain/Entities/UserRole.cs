using System.Collections.Generic;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class UserRole : Entity
    {
        public UserRole()
        {
            Users = new HashSet<User>();
        }

        public string NameAlias { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}