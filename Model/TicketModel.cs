namespace APIProject.Model;

public class Ticket
{
    public int IdTicket { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public User? UserId { get; set; }
}
