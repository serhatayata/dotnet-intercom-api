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


}
