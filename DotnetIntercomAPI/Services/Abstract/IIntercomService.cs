using DotnetIntercomAPI.Responses.Admins;

namespace DotnetIntercomAPI.Services.Abstract;

public interface IIntercomService
{
    Task<IdentifyAdminResponse> IdentifyAdmin(CancellationToken cancellationToken = default);
    Task<AdminUserResponse> SetAdminAway(string id, CancellationToken cancellationToken = default);
    Task<ListAllActivityLogsResponse> ListAllActivityLogs(string createdAtAfter, string createdAtBefore, CancellationToken cancellationToken = default);
    Task<ListAdminsResponse> ListAllAdmins(CancellationToken cancellationToken = default);
    Task<AdminUserResponse> RetrieveAdmin(string id, CancellationToken cancellationToken = default);
}
