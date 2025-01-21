using DotnetIntercomAPI.Requests;
using DotnetIntercomAPI.Requests.Contacts;
using DotnetIntercomAPI.Requests.Conversations;
using DotnetIntercomAPI.Requests.DataAttributes;
using DotnetIntercomAPI.Requests.DataEvents;
using DotnetIntercomAPI.Responses.Admins;
using DotnetIntercomAPI.Responses.Companies;
using DotnetIntercomAPI.Responses.Contacts;
using DotnetIntercomAPI.Responses.Conversations;
using DotnetIntercomAPI.Responses.DataAttributes;
using DotnetIntercomAPI.Responses.DataEvents;
using DotnetIntercomAPI.Responses.Tags;

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
    Task<CompanyListResponse> ListAllCompanies(PagesRequest request, CancellationToken cancellationToken = default);
    #endregion
    #region Contacts
    Task<ContactResponse> GetContact(string id, CancellationToken cancellationToken = default);
    Task<ContactListResponse> ListAttachedContacts(string id, CancellationToken cancellationToken = default);
    Task<ContactListResponse> ListAllContacts(PagesRequest request, CancellationToken cancellationToken = default);
    Task<ContactCreateOrUpdateResponse> CreateOrUpdateContact(string id, ContactCreateOrUpdateRequest model, CancellationToken cancellationToken = default);
    Task<ContactDeleteResponse> DeleteContact(string id, CancellationToken cancellationToken = default);
    #endregion
    #region Conversations
    Task<TagAddResponse> AddTagToConversation(string conversationId, ConversationAddTagRequest request, CancellationToken cancellationToken);
    Task<TagDeleteResponse> RemoveTagFromConversation(string conversationId, string id, ConversationRemoveTagRequest request, CancellationToken cancellationToken);
    Task<ConversationListResponse> ListAllConversations(PagesRequest request, CancellationToken cancellationToken = default);
    Task<ConversationCreateResponse> CreateConversation(ConversationCreateRequest request, CancellationToken cancellationToken);
    Task<ConversationResponse> RetrieveConversation(string id, string displayAs = "plaintext", CancellationToken cancellationToken = default);
    Task<ConversationResponse> UpdateConversation(string id, ConversationUpdateRequest model, CancellationToken cancellationToken);
    Task<ConversationResponse> ReplyConversation(string id, ConversationReplyRequest model, CancellationToken cancellationToken);
    #endregion
    #region DataAttributes
    Task<DataAttributeListResponse> ListAllDataAttributes(DataAttributeListRequest request, CancellationToken cancellationToken = default);
    Task<DataAttributeResponse> CreateDataAttribute(DataAttributeCreateRequest model, CancellationToken cancellationToken = default);
    Task<DataAttributeResponse> UpdateDataAttribute(int id, DataAttributeUpdateRequest model, CancellationToken cancellationToken = default);
    #endregion
    #region DataEvents
    Task<bool> SubmitDataEvent(DataEventSubmitRequest model, CancellationToken cancellationToken = default);
    Task<DataEventListResponse> ListAllDataEvents(DataEventListRequest model, CancellationToken cancellationToken = default);
    #endregion
}