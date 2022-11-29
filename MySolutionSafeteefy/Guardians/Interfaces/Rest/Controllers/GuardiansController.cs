using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MySolutionSafeteefy.Guardians.Domain.Models;
using MySolutionSafeteefy.Guardians.Domain.Services;
using MySolutionSafeteefy.Guardians.Resources;
using MySolutionSafeteefy.Shared.Extensions;

namespace MySolutionSafeteefy.Guardians.Interfaces.Rest.Controllers;


[ApiController]
[Route("/api/[controller]")]
public class GuardiansController : ControllerBase
{
    private readonly IGuardianService _guardianService; //Foco amarillo generate constructor
    private readonly IMapper _mapper;

    
    public GuardiansController(IGuardianService guardianService, IMapper mapper)
    {
        _guardianService = guardianService;
        _mapper = mapper;
    }

    //------------------------------------------------  ENDPOINTS 
    

    [HttpGet]
    public async Task<IEnumerable<GuardianResource>> GetAllAsync()
    {
        var guardians = await _guardianService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Guardian>, IEnumerable<GuardianResource>>(guardians);

        return resources;
    }
    
    [HttpGet("{id}")]
    public async Task<GuardianResource> GetByIdAsync(int id)
    {
        var guardians = await _guardianService.FindByIdAsync(id);
        var resources = _mapper.Map<Guardian, GuardianResource>(guardians);

        return resources;
    }

    [HttpPost]
    [ProducesResponseType(typeof(GuardianResource),201)]
    [ProducesResponseType(typeof(List<string>), 400)]
    [ProducesResponseType(500)]
    public async Task<IActionResult> PostAsync([FromBody] SaveGuardianResource resource)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

        var guardian = _mapper.Map<SaveGuardianResource, Guardian>(resource);
        var result = await _guardianService.SaveAsync(guardian);

        if (!result.Success) return BadRequest(result.Message);

        var guardianResource = _mapper.Map<Guardian, GuardianResource>(result.Resource);
        return Created(nameof(PostAsync), guardianResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id,[FromBody] SaveGuardianResource resource)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

        var guardian = _mapper.Map<SaveGuardianResource, Guardian>(resource);
        var result = await _guardianService.UpdateAsync(id,guardian);
        
        if (!result.Success) return BadRequest(result.Message);

        var guardianResource = _mapper.Map<Guardian, GuardianResource>(result.Resource);
        return Ok(guardianResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _guardianService.DeleteAsync(id);

        if (!result.Success) return BadRequest(result.Message);

        var guardianResource = _mapper.Map<Guardian, GuardianResource>(result.Resource);

        return Ok(guardianResource);


    }






}