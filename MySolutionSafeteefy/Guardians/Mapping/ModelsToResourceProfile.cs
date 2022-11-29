using AutoMapper;
using MySolutionSafeteefy.Guardians.Domain.Models;
using MySolutionSafeteefy.Guardians.Resources;
using MySolutionSafeteefy.Urgencies.Domain.Models;

namespace MySolutionSafeteefy.Guardians.Mapping;

//Esta clase convierte de Guardian a GuardianResource , dandole solo los datos minimos que espera el
//exterior de Guardian y se lo brinda atravez de GuardianResource quien muestra lo minimo esperad al
//exterior

public class ModelsToResourceProfile : Profile  //Descendiente de profile, generar constructor sin parametros
{
    public ModelsToResourceProfile()
    {
        CreateMap<Guardian, GuardianResource>();
        //Si hay mas entidades dentro del bounded se siguen creando aqui
    }
}

//Ahora creamos el ModelStateExtensions en Shared.Extensions

