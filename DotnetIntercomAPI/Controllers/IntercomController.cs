using System.Threading;
using DotnetIntercomAPI.Requests;
using DotnetIntercomAPI.Requests.Contacts;
using DotnetIntercomAPI.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DotnetIntercomAPI.Controllers;

[Route("api/intercom")]
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
    [FromQuery] PagesRequest request,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.ListAllCompanies(request, cancellationToken);
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

    [HttpGet("list-contacts")]
    public async Task<IActionResult> ListContacts(
    [FromQuery] PagesRequest request,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.ListAllContacts(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost("create-contact")]
    public async Task<IActionResult> CreateContact(
    [FromBody] ContactCreateOrUpdateRequest model,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.CreateOrUpdateContact(string.Empty, model, cancellationToken);
        return Ok(response);
    }

    [HttpPut("update-contact/{id}")]
    public async Task<IActionResult> UpdateContact(
    string id,
    [FromBody] ContactCreateOrUpdateRequest model,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.CreateOrUpdateContact(id, model, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("delete-contact/{id}")]
    public async Task<IActionResult> DeleteContact(
    string id,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.DeleteContact(id, cancellationToken);
        return Ok(response);
    }
    #endregion
}
