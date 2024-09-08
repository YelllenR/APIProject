using APIProject.Auth;
using APIProject.Model;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Security.Cryptography;
namespace APIProject.Services.Users;

public class UserService : IUserService
{

    public Task<List<Ticket>> GetUserTickets(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> GetUser()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserId(string email)
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> GetOneTicket(int userId, int ticketId, bool IsAuthorized)
    {
        throw new NotImplementedException();
    }

    public string GetUserToken(string email)
    {
        string token = CustomJwtToken.IssueToken(email);

        return token;
    }

    public Task<Ticket> GetOneTicket(int userId, int ticketId)
    {
        throw new NotImplementedException();
    }
}
