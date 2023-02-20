using JwtWebApi.Dto;
using JwtWebApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //use repository with authenticatrion service

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            return null;
        }
    }
}
