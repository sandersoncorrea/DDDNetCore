using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using ProjectDDD.API.Services;
using ProjectDDD.Domain.Entities;

namespace ProjectDDD.API.Controllers
{
    [Route("v1/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IDistributedCache _distributedCache;
        public LoginController(IDistributedCache distributedCache)
        {
            _distributedCache = distributedCache;
        }

        [HttpPost]
        public ActionResult<string> Auth([FromBody]LoginDTO user)
        {
            try
            {
                if (user == null)
                    return NotFound();

                string token = TokenService.GenerateToken(user);

                var config = new DistributedCacheEntryOptions();
                _distributedCache.SetString(user.Username, token);

                return Ok(new { token, user });
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public IActionResult GetValue(string username)
        {
            var value = _distributedCache.GetString(username);
            return Ok(value);
        }
    }
}
