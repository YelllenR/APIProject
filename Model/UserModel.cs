using System.Security.Claims;

namespace APIProject.Model;

public class User
{
    //public int Id { get; }
    public string Email { get; } = string.Empty;

    public string Token { get; set;  } = string.Empty;    

    //public Task<List<Ticket>> Tickets { get; set; }

    //public IEnumerable<string> Roles { get; set; }
    //public IEnumerable<Claim> Claims()
    //{
    //    List<Claim> claims = new List<Claim> { new Claim(ClaimTypes.Name, Email) };
    //    //claims.AddRange(Roles.Select(role => new Claim(ClaimTypes.Role, role)));

    //    return claims;
    //}


}
