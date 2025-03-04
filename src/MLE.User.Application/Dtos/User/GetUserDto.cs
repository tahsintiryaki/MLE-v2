using System.Security.AccessControl;

namespace MLE.User.Application.Dtos.User;

public class GetUserDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
}