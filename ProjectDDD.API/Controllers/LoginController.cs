using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDDD.API.Services;
using ProjectDDD.Domain.Entities;

namespace ProjectDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> Auth([FromBody]LoginDTO user)
        {
            if (user == null)
                return NotFound();

            var token = TokenService.GenerateToken(user);
            return Ok(new { token, user });
        }
    }
}
