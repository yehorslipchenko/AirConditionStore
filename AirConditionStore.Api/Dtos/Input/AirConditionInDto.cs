using AirConditionStore.Domain.Entities;

namespace AirConditionStore.Api.Dtos.Input
{
    public class AirConditionInDto
    {
        public string Name { get; set; }
        public int RoomArea { get; set; }
        public int Price { get; set; }

        public BrandInDto Brand { get; set; }
        public StatusInDto Status { get; set; }
        public AirConditionTypeInDto AirConditionType { get; set; }
        public OperationNegativeTemperatureInDto NegativeTemperatures { get; set; }
        public IndorUnitInstallationTypeInDto InstallationType { get; set; }
    }
}