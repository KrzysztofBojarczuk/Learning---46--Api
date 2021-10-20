using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Api;

namespace WebApplication1.Controllers
{
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        [Route("/api/token")]
        public async Task<IActionResult> RequestToken(TokenRequest tokenRequest)
        {
            var token = await _authenticationService.RequestTokenAsync(tokenRequest);
            return Ok(token);
        }
    }
}
