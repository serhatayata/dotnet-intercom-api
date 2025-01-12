using DotnetIntercomAPI.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DotnetIntercomAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IntercomController : ControllerBase
{
    private readonly IIntercomService _intercomService;

    public IntercomController(
    IIntercomService intercomService)
    {
        _intercomService = intercomService;
    }

    [HttpGet("retrieve-admin/{id}")]
    public async Task<IActionResult> RetrieveAdmin(
    string id, 
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.RetrieveAdmin(id, cancellationToken);
        return Ok(response);
    }

    [HttpGet("list-all-admins")]
    public async Task<IActionResult> ListAllAdmins(
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ListAllAdmins(cancellationToken);
        return Ok(response);
    }
}
