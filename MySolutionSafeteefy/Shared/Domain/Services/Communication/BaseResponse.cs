namespace MySolutionSafeteefy.Shared.Domain.Services.Communication;

//Esto solo copia y pega

public abstract class BaseResponse<T>
{
    protected BaseResponse(string message)
    {
        Message = message;
    }

    protected BaseResponse(T resource)
    {
        Resource = resource;
    }

    public bool Success { get; set; } 
    public string Message { get; set; } 
    public T Resource { get; set; }
}

// De aqui vamos al Guardians.Domain.Services.Communication y creamos el GuardianResponse,
// lo mismo hacemos para los demas bounded context
