using System;
using AirConditionStore.Api.Dtos.Input;
using AirConditionStore.Domain.Entities;
using AutoMapper;

namespace AirConditionStore.Api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserInformationInDto, UserInformation>().ReverseMap();
            CreateMap<UserInDto, User>()
                .ForMember(x 
                    => x.Information, x 
                    => x.MapFrom(z => z.UserInfo)).ReverseMap();
        }
    }
}