using MySolutionSafeteefy.Urgencies.Domain.Models;

namespace MySolutionSafeteefy.Guardians.Domain.Models;

public class Guardian
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public string Adress { get; set; }
    public List<Urgency> UrgenciesList { get; set; } = new List<Urgency>();
}