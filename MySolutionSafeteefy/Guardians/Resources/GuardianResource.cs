namespace MySolutionSafeteefy.Guardians.Resources;

//En esta clase va lo minimo indispensable que el exterior deberia esperar de un category

public class GuardianResource
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public string Adress { get; set; }
}


//De aqui creamos el SaveGuardianResource en Guardians.Resources;