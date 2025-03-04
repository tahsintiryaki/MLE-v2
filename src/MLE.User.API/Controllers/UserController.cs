using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MLE.User.Application.Dtos.User;
using MLE.User.Application.Interfaces.Services;

namespace MLE.User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDto createUserDto)
        {
            await _userService.CreateUser(createUserDto);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var response = await _userService.GetAllUsers();
            return Ok(response);
        }
    }
}