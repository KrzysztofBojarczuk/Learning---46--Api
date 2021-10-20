using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Controllers.Api;
using WebApplication1.Controllers.Domain;

namespace WebApplication1.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public async Task<User> GetUserByEmailAsync(string email)
        {
            try
            {
                using (var connection = new SqlConnection("server=localhost;database=savijsell;trusted_connection=true"))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@Email", email);

                    var results = await connection.QueryAsync<User>("stp_Users_GetByEmail",
                             parameters, commandType: CommandType.StoredProcedure);

                    if (results != null)
                    {
                        return results.FirstOrDefault();
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                // logging
                throw;
            }
        }

        public async Task InsertUserAsync(UserSignUp user)
        {
            try
            {
                using (var connection = new SqlConnection("server=localhost;database=savijsell;trusted_connection=true"))
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@FirstName", user.FirstName);
                    parameters.Add("@LastName", user.LastName);
                    parameters.Add("@Email", user.Email);
                    parameters.Add("@Password", user.Password);
                    parameters.Add("@PostalCode", user.PostalCode);
                    parameters.Add("@UserName", user.UserName);
                    await connection.ExecuteAsync("stp_Users_Insert", parameters,
                        commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                // logging
                throw;
            }

        }
    }
}
