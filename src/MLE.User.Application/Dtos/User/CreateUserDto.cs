using System.Security.AccessControl;

namespace MLE.User.Application.Dtos.User;

public class CreateUserDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}