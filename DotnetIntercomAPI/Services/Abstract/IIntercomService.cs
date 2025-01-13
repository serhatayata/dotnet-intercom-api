using DotnetIntercomAPI.Responses.Admins;
using DotnetIntercomAPI.Responses.Companies;
using DotnetIntercomAPI.Responses.Contacts;

namespace DotnetIntercomAPI.Services.Abstract;

public interface IIntercomService
{
    Task<IdentifyAdminResponse> IdentifyAdmin(CancellationToken cancellationToken = default);
    Task<AdminUserResponse> SetAdminAway(string id, CancellationToken cancellationToken = default);
    Task<ListAllActivityLogsResponse> ListAllActivityLogs(string createdAtAfter, string createdAtBefore, CancellationToken cancellationToken = default);
    Task<ListAdminsResponse> ListAllAdmins(CancellationToken cancellationToken = default);
    Task<AdminUserResponse> RetrieveAdmin(string id, CancellationToken cancellationToken = default);
    Task<CompanyListResponse> ListAllCompanies(string order = "asc", int page = 1, int perPage = 1, CancellationToken cancellationToken = default);
    Task<ContactResponse> GetContact(string id, CancellationToken cancellationToken = default);
}