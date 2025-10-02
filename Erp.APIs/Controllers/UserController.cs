using Microsoft.AspNetCore.Mvc;
using Erp.BL.Services.Users;
using Erp.BL.DTOs.UserDto;

namespace Erp.APIs.Controllers
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

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Create([FromBody] UserDto user)
        {
            _userService.CreateUser(user);
            return Ok();
        }
    }
}