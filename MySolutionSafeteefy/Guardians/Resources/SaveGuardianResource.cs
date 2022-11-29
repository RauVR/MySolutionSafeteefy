using System.ComponentModel.DataAnnotations;

namespace MySolutionSafeteefy.Guardians.Resources;

//Esta clase recive todo lo q se le envia del exterior 

public class SaveGuardianResource
{
    //Aqui van todos los constraints 
    
    
    [MaxLength(60)]
    public string FirstName { get; set; }
    
    [MaxLength(60)]
    public string LastName { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string UserName { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string Email { get; set; }
    
    [Required]
    public string Gender { get; set; }
    
    public string Adress { get; set; }
}

//Ahora nos vamos a Guardians.Mapping y creamos la clase ModelsToResourceProfile 