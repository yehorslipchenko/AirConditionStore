using System.Collections.Generic;
using System.Threading.Tasks;
using AirConditionStore.Api.Dtos.Input;
using AirConditionStore.Domain.Entities;
using AirConditionStore.Logic;
using AirConditionStore.Logic.Contracts;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AirConditionStore.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUserService userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            this.mapper = mapper;
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var users = await userService.GetUsersAsync();
            var usersDto = mapper.Map<IEnumerable<User>, IEnumerable<UserInDto>>(users);

            return Ok(usersDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserInDto userInDto)
        {
            var user = mapper.Map<UserInDto, User>(userInDto);
            await userService.CreateUserAsync(user);

            return Ok();
        }

        [HttpDelete("{login}")]
        public async Task<IActionResult> RemoveUser(string login)
        {
            await userService.RemoveUser(login);

            return Ok();
        }
    }
}