using APIProject.Model;
namespace APIProject.Services.Users;

public interface IUserService
{
    public Task<List<User>> GetUser();

    public Task<User> GetUserId(string email);

    public Task<List<Ticket>> GetUserTickets(int userId);

    public Task<Ticket> GetOneTicket(int userId, int ticketId);

    public string GetUserToken(string email);

}
