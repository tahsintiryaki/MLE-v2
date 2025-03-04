using MLE.User.Application.Dtos.User;

namespace MLE.User.Application.Interfaces.Services;

public interface IUserService
{
    Task<GetUserDto> GetById(Domain.Entities.User user);
    Task CreateUser(CreateUserDto createUserDto);
    Task<List<GetUserDto>> GetAllUsers();
}