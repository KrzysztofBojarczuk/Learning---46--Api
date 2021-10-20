using System.Threading.Tasks;
using WebApplication1.Controllers.Api;
using WebApplication1.Controllers.Domain;

namespace WebApplication1.Services
{
    public interface IUsersService
    {

        Task InsertUserAsync(UserSignUp user);
        Task<User> LoginUserAsync(TokenRequest login);
    }
}