using AirConditionStore.Api.Dtos.Input;
using AirConditionStore.Domain.Entities;
using AutoMapper;

namespace AirConditionStore.Api.Profiles
{
    public class AirConditionProfile : Profile
    {
        public AirConditionProfile()
        {
            CreateMap<AirConditionTypeInDto, AirConditionType>().ReverseMap();
            CreateMap<BrandInDto, Brand>().ReverseMap();
            CreateMap<IndorUnitInstallationTypeInDto, IndoorUnitInstallationType>().ReverseMap();
            CreateMap<OperationNegativeTemperatureInDto, OperationNegativeTemperature>().ReverseMap();
            CreateMap<StatusInDto, Status>().ReverseMap();

            CreateMap<AirConditionInDto, AirCondition>()
                .ForMember(x =>
                    x.Brand, x
                    => x.MapFrom(z => z.Brand))
                .ForMember(x =>
                    x.AirConditionType, x
                    => x.MapFrom(z => z.AirConditionType))
                .ForMember(x =>
                    x.IndoorUnitInstallationType, x
                    => x.MapFrom(z => z.InstallationType))
                .ForMember(x =>
                    x.OperationNegative, x
                    => x.MapFrom(z => z.NegativeTemperatures))
                .ForMember(x =>
                    x.Status, x
                    => x.MapFrom(z => z.Status)).ReverseMap();
        }
    }
}