using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleFlashCardApi.Interfaces;
using SimpleFlashCardApi.Mappers;
using SimpleFlashCardApi.Models;

namespace SimpleFlashCardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserRepository userRepository) : ControllerBase
    {
        private readonly IUserRepository _userRepository = userRepository;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public  IActionResult GetUsers()
        {
            var users = _userRepository.GetUsers();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var usersDto = users.Select(u => u.ToUserDto());

            return Ok(usersDto);
        }


        [HttpGet("{userId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        [ProducesResponseType(400)]
        public IActionResult GetUser(int userId)
        {
            if(!_userRepository.IsExists(userId))
                return NotFound();

            User user = _userRepository.GetUser(userId);
            
            if(!ModelState.IsValid)
                return BadRequest();

            return Ok(user.ToUserDto());
        }

    }
}
