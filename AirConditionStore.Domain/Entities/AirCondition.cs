using System.Collections.Generic;
using AirConditionStore.Domain.Contracts;

namespace AirConditionStore.Domain.Entities
{
    public class AirCondition : Entity
    {
        public AirCondition()
        {
            Orders = new HashSet<Order>();
            Modes = new HashSet<OperatingMode>();
            Capabilities = new HashSet<Capability>();
            ControlTypes = new HashSet<ControlType>();
            Countries = new HashSet<ProducingCountry>();
        }
        
        public int RoomArea { get; set; }

        public string BrandId { get; set; }
        public int StatusId { get; set; }
        public int AirConditionTypeId { get; set; }
        public int OperationNegativeId { get; set; }
        public int IndoorUnitInstallationTypeId { get; set; }
        
        
        public virtual Brand Brand { get; set; }
        public virtual Status Status { get; set; }
        public virtual AirConditionType AirConditionType { get; set; }
        public virtual OperationNegativeTemperature OperationNegative { get; set; }
        public virtual IndoorUnitInstallationType IndoorUnitInstallationType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<OperatingMode> Modes { get; set; }
        public virtual ICollection<Capability> Capabilities { get; set; }
        public virtual ICollection<ControlType> ControlTypes { get; set; }
        public virtual ICollection<ProducingCountry> Countries { get; set; }
        
    }
}
