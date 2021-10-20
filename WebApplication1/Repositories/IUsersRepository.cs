using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Api;
using WebApplication1.Controllers.Domain;

namespace WebApplication1.Repositories
{
    public interface IUsersRepository
    {

        Task InsertUserAsync(UserSignUp user);
        Task<User> GetUserByEmailAsync(string email);
    }
}
