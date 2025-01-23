using DotnetIntercomAPI.Requests;
using DotnetIntercomAPI.Requests.Companies;
using DotnetIntercomAPI.Requests.Contacts;
using DotnetIntercomAPI.Requests.Conversations;
using DotnetIntercomAPI.Requests.DataAttributes;
using DotnetIntercomAPI.Requests.DataEvents;
using DotnetIntercomAPI.Requests.Messages;
using DotnetIntercomAPI.Requests.Segments;
using DotnetIntercomAPI.Requests.Tags;
using DotnetIntercomAPI.Requests.Tickets;
using DotnetIntercomAPI.Requests.TicketTypes;
using DotnetIntercomAPI.Responses.Admins;
using DotnetIntercomAPI.Responses.Companies;
using DotnetIntercomAPI.Responses.Contacts;
using DotnetIntercomAPI.Responses.Conversations;
using DotnetIntercomAPI.Responses.DataAttributes;
using DotnetIntercomAPI.Responses.DataEvents;
using DotnetIntercomAPI.Responses.Messages;
using DotnetIntercomAPI.Responses.Segments;
using DotnetIntercomAPI.Responses.Tags;
using DotnetIntercomAPI.Responses.Tickets;
using DotnetIntercomAPI.Responses.TicketTypes;

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
    Task<TagResponse> TagCompany(CompanyTagRequest model, CancellationToken cancellationToken = default);
    #endregion
    #region Contacts
    Task<ContactResponse> GetContact(string id, CancellationToken cancellationToken = default);
    Task<ContactListResponse> ListAttachedContacts(string id, CancellationToken cancellationToken = default);
    Task<ContactListResponse> ListAllContacts(PagesRequest request, CancellationToken cancellationToken = default);
    Task<ContactCreateOrUpdateResponse> CreateOrUpdateContact(string id, ContactCreateOrUpdateRequest model, CancellationToken cancellationToken = default);
    Task<ContactDeleteResponse> DeleteContact(string id, CancellationToken cancellationToken = default);
    Task<TagResponse> AddTagToContact(string id, ContactAddTagRequest model, CancellationToken cancellationToken = default);
    Task<TagResponse> RemoveTagFromContact(string contactId, string id, CancellationToken cancellationToken = default);
    Task<TagResponse> ContactTag(ContactTagRequest model, CancellationToken cancellationToken = default);
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
    #region Messages
    Task<MessageCreateResponse> CreateMessage(MessageCreateRequest model, CancellationToken cancellationToken = default);
    #endregion
    #region Segments
    Task<SegmentListContactResponse> ListContactAttachedSegments(string id, CancellationToken cancellationToken = default);
    Task<SegmentListResponse> ListAllSegments(SegmentListRequest model, CancellationToken cancellationToken = default);
    Task<SegmentResponse> RetrieveSegment(string id, CancellationToken cancellationToken = default);
    #endregion
    #region Tags
    Task<TagListResponse> ListContactTags(string id, CancellationToken cancellationToken = default);
    Task<TagListResponse> ListAllTags(CancellationToken cancellationToken = default);
    Task<TagResponse> CreateTag(TagCreateRequest model, CancellationToken cancellationToken = default);
    Task<TagResponse> UpdateTag(TagUpdateRequest model, CancellationToken cancellationToken = default);
    Task<TagResponse> RetrieveTag(string id, CancellationToken cancellationToken = default);
    Task<bool> DeleteTag(string id, CancellationToken cancellationToken = default);
    #endregion
    #region Tickets
    Task<TagResponse> AddTagToTicket(string id, TicketAddTagRequest model, CancellationToken cancellationToken = default);
    Task<TagResponse> RemoveTagFromTicket(string ticketId, string tagId, TicketRemoveTagRequest model, CancellationToken cancellationToken = default);
    Task<TicketResponse> CreateTicket(TicketCreateRequest model, CancellationToken cancellationToken = default);
    Task<TicketResponse> UpdateTicket(string id, TicketUpdateRequest model, CancellationToken cancellationToken = default);
    Task<TicketReplyResponse> ReplyToTicket(string id, TicketReplyRequest model, CancellationToken cancellationToken = default);
    Task<TicketResponse> RetrieveTicket(string id, CancellationToken cancellationToken = default);
    #endregion
    #region TicketTypes
    Task<TicketTypeListResponse> ListAllTicketTypes(CancellationToken cancellationToken = default);
    Task<TicketTypeResponse> CreateTicketType(TicketTypeCreateRequest model, CancellationToken cancellationToken = default);
    Task<TicketTypeResponse> RetrieveTicketType(string id, CancellationToken cancellationToken = default);
    Task<TicketTypeResponse> UpdateTicketType(string id, TicketTypeUpdateRequest model, CancellationToken cancellationToken = default);
    #endregion
}