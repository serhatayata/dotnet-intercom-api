using DotnetIntercomAPI.Responses.Admins;

namespace DotnetIntercomAPI.Services.Abstract;

public interface IIntercomService
{
    Task<IdentifyAdminResponse> IdentifyAdmin();
}
