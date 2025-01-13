using DotnetIntercomAPI.Requests.Admins;
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

    #region Admins
    [HttpGet("identify-admin")]
    public async Task<IActionResult> IdentifyAdmin(
    string id,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.IdentifyAdmin(cancellationToken);
        return Ok(response);
    }

    [HttpPut("set-admin-away/{id}")]
    public async Task<IActionResult> SetAdminAway(
    string id,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.SetAdminAway(id, cancellationToken);
        return Ok(response);
    }

    [HttpGet("retrieve-admin/{id}")]
    public async Task<IActionResult> RetrieveAdmin(
    string id, 
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.RetrieveAdmin(id, cancellationToken);
        return Ok(response);
    }

    [HttpGet("list-all-activity-logs")]
    public async Task<IActionResult> ListAllActivityLogs(
    [FromQuery] string createdAtBefore,
    [FromQuery] string createdAtAfter,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ListAllActivityLogs(createdAtAfter, createdAtBefore, cancellationToken);
        return Ok(response);
    }

    [HttpGet("list-all-admins")]
    public async Task<IActionResult> ListAllAdmins(
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ListAllAdmins(cancellationToken);
        return Ok(response);
    }
    #endregion
    #region Companies
    [HttpGet("list-all-companies")]
    public async Task<IActionResult> ListAllCompanies(
    string order = "asc",
    int page = 1,
    int perPage = 1,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.ListAllCompanies(order, page, perPage, cancellationToken);
        return Ok(response);
    }
    #endregion
    #region Contacts
    [HttpGet("get-contact/{id}")]
    public async Task<IActionResult> GetContact(
    string id,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.GetContact(id, cancellationToken);
        return Ok(response);
    }
    #endregion
}
