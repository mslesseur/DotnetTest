using AutoMapper;
using dotnet_test.Dtos;
using dotnet_test.Dtos.User;
using dotnet_test.Dtos.User;

namespace dotnet_test
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, GetUserDto>();
            CreateMap<AddUserDto, User>();
            CreateMap<UpdateUserDto, User>();
        }
    }
}