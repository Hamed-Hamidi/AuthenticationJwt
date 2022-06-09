using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationJwt.Common;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace AuthenticationJwt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdentityController : Controller
    {
        private readonly IJwtHandler _jwtHandler;

        public IdentityController(IJwtHandler jwtHandler)
        {
            _jwtHandler = jwtHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Login(string username, string password)
        {
            //todo check username and password from db
            if (username == "hamed" && password == "654321")
                return Ok(_jwtHandler.CreateToken("12121", "Admin"));
            return BadRequest("user not found!");
        }
    }
}
