using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Api;

namespace WebApplication1.Services
{
    public interface IAuthenticationService
    {
        Task<TokenResponse> RequestTokenAsync(TokenRequest tokenRequest);
    }
}
