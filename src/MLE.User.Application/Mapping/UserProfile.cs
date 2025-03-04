using AutoMapper;
using MLE.User.Application.Dtos.User;

namespace MLE.User.Application.Mapping;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<CreateUserDto, Domain.Entities.User>().ReverseMap();
        CreateMap<GetUserDto, Domain.Entities.User>().ReverseMap();
    }
}