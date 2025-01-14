using DotnetIntercomAPI.Requests;
using DotnetIntercomAPI.Requests.Contacts;
using DotnetIntercomAPI.Responses.Admins;
using DotnetIntercomAPI.Responses.Companies;
using DotnetIntercomAPI.Responses.Contacts;

namespace DotnetIntercomAPI.Services.Abstract;

public interface IIntercomService
{
    #region Admins
    Task<IdentifyAdminResponse> IdentifyAdmin(CancellationToken cancellationToken = default);
    Task<AdminUserResponse> SetAdminAway(string id, CancellationToken cancellationToken = default);
    Task<ListAllActivityLogsResponse> ListAllActivityLogs(string createdAtAfter, string createdAtBefore, CancellationToken cancellationToken = default);
    Task<ListAdminsResponse> ListAllAdmins(CancellationToken cancellationToken = default);
    Task<AdminUserResponse> RetrieveAdmin(string id, CancellationToken cancellationToken = default);
    #endregion
    #region Companies
    Task<CompanyListResponse> ListAllCompanies(string order = "asc", int page = 1, int perPage = 1, CancellationToken cancellationToken = default);
    #endregion
    #region Contacts
    Task<ContactResponse> GetContact(string id, CancellationToken cancellationToken = default);
    Task<ContactListResponse> ListAttachedContacts(string id, CancellationToken cancellationToken = default);
    Task<ContactListResponse> ListAllContacts(PagesRequest request, CancellationToken cancellationToken = default);
    Task<ContactCreateOrUpdateResponse> CreateOrUpdateContact(string id, ContactCreateOrUpdateRequest model, CancellationToken cancellationToken = default);
    Task<ContactDeleteResponse> DeleteContact(string id, CancellationToken cancellationToken = default);
    #endregion
}