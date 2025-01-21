using System.Reflection;
using System.Text;
using DotnetIntercomAPI.Helpers;
using DotnetIntercomAPI.Requests;
using DotnetIntercomAPI.Requests.Admins;
using DotnetIntercomAPI.Requests.Companies;
using DotnetIntercomAPI.Requests.Contacts;
using DotnetIntercomAPI.Requests.Conversations;
using DotnetIntercomAPI.Requests.DataAttributes;
using DotnetIntercomAPI.Requests.DataEvents;
using DotnetIntercomAPI.Requests.Messages;
using DotnetIntercomAPI.Requests.Segments;
using DotnetIntercomAPI.Requests.Tags;
using DotnetIntercomAPI.Requests.Tickets;
using DotnetIntercomAPI.Responses.Admins;
using DotnetIntercomAPI.Responses.Companies;
using DotnetIntercomAPI.Responses.Contacts;
using DotnetIntercomAPI.Responses.Conversations;
using DotnetIntercomAPI.Responses.DataAttributes;
using DotnetIntercomAPI.Responses.DataEvents;
using DotnetIntercomAPI.Responses.Messages;
using DotnetIntercomAPI.Responses.Segments;
using DotnetIntercomAPI.Responses.Tags;
using DotnetIntercomAPI.Services.Abstract;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DotnetIntercomAPI.Services.Concrete;

public class IntercomService : IIntercomService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<IntercomService> _logger;

    public IntercomService(
    IHttpClientFactory httpClientFactory,
    ILogger<IntercomService> logger)
    {
        _httpClient = httpClientFactory.CreateClient("intercom");
        _logger = logger;
    }

    #region Admins
    /// <summary>
    /// You can view the currently authorised admin along with the embedded app object 
    /// </summary>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="IdentifyAdminResponse"/></returns>
    public async Task<IdentifyAdminResponse> IdentifyAdmin(
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<IdentifyAdminResponse>(endpoint: "me", 
                                                         parameters: null, 
                                                         cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can set an Admin as away for the Inbox.
    /// </summary>
    /// <param name="id">id of the admin</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="AdminUserResponse"/></returns>
    public async Task<AdminUserResponse> SetAdminAway(
    string id, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await PutAsync<SetAdminAwayRequest, AdminUserResponse>($"admins/{id}/away", new SetAdminAwayRequest
            {
                AwayModeEnabled = true,
                AwayModeReassign = true
            }, cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can get a log of activities by all admins
    /// </summary>
    /// <param name="createdAtAfter">create at after</param>
    /// <param name="createdAtBefore">created at before</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ListAllActivityLogsResponse"/></returns>
    public async Task<ListAllActivityLogsResponse> ListAllActivityLogs(
    string createdAtAfter,
    string createdAtBefore,
    CancellationToken cancellationToken = default)
    {
        try
        {
            var parameters = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(createdAtAfter))
                parameters.Add("created_at_after", createdAtAfter);
            if (!string.IsNullOrEmpty(createdAtBefore))
                parameters.Add("created_at_before", createdAtBefore);

            return await GetAsync<ListAllActivityLogsResponse>(endpoint: "admins/activity_logs", 
                                                               parameters: parameters, 
                                                               cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can fetch a list of admins for a given workspace.
    /// </summary>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ListAdminsResponse"/></returns>
    public async Task<ListAdminsResponse> ListAllAdmins(
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<ListAdminsResponse>(endpoint: "admins",
                                                      parameters: null,
                                                      cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can retrieve the details of a single admin.
    /// </summary>
    /// <param name="id">id of admin</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">throws exception if id is null</exception>
    public async Task<AdminUserResponse> RetrieveAdmin(
    string id, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id));

            return await GetAsync<AdminUserResponse>($"admins/{id}",
                                                     parameters: null,
                                                     cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }
    #endregion
    #region Companies
    /// <summary>
    /// You can list companies.
    /// </summary>
    /// <param name="order">ordering by asc or desc</param>
    /// <param name="page">page size</param>
    /// <param name="perPage">items per page</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="CompanyListResponse"/></returns>
    public async Task<CompanyListResponse> ListAllCompanies(
    PagesRequest request,
    CancellationToken cancellationToken = default)
    {
        try
        {
            string url = $"companies/list?order={request.Order}&page={request.Page}&per_page={request.PerPage}";
            return await PostAsync<object, CompanyListResponse>(endpoint: url, 
                                                                data: null,
                                                                cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can tag single company or a list of companies. You can tag a company by passing in the tag name and the company details
    /// </summary>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="TagResponse"/></returns>
    public async Task<TagResponse> TagCompany(
    CompanyTagRequest model,
    CancellationToken cancellationToken)
    {
        try
        {
            return await PostAsync<CompanyTagRequest, TagResponse>(endpoint: $"tags",
                                                                   data: model,
                                                                   cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }
    #endregion
    #region Contacts

    /// <summary>
    /// You can fetch a list of all contacts that belong to a company.
    /// </summary>
    /// <param name="id">The unique identifier for the company which is given by Intercom</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ContactListResponse"/></returns>
    public async Task<ContactListResponse> ListAttachedContacts(
    string id,
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<ContactListResponse>(endpoint: $"companies/{id}/contacts", 
                                                       parameters: null, 
                                                       cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can fetch a list of all contacts (ie. users or leads) in your workspace.
    /// </summary>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ContactListResponse"/></returns>
    public async Task<ContactListResponse> ListAllContacts(
    PagesRequest request,
    CancellationToken cancellationToken = default)
    {
        try
        {
            var parameters = HttpHelper.ToSnakeCaseQueryStringAsDictionary<PagesRequest>(request);

            return await GetAsync<ContactListResponse>(endpoint: "contacts", 
                                                       parameters: parameters, 
                                                       cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can fetch the details of a single contact.
    /// </summary>
    /// <param name="id">id</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ContactListResponse"/></returns>
    public async Task<ContactResponse> GetContact(
    string id,
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<ContactResponse>(endpoint: $"contacts/{id}", 
                                                   parameters: null, 
                                                   cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// Create or update a contact
    /// </summary>
    /// <param name="id">id of contact</param>
    /// <param name="model">model to process</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ContactCreateOrUpdateResponse"/></returns>
    public async Task<ContactCreateOrUpdateResponse> CreateOrUpdateContact(
    string id,
    ContactCreateOrUpdateRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            if (!string.IsNullOrEmpty(id))
                return await PostAsync<ContactCreateOrUpdateRequest, ContactCreateOrUpdateResponse>(endpoint: "contacts", 
                                                                                              data: model, 
                                                                                              cancellationToken: cancellationToken);
            else
                return await PostAsync<ContactCreateOrUpdateRequest, ContactCreateOrUpdateResponse>(endpoint: $"contacts/{id}", 
                                                                                              data: model, 
                                                                                              cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }    
    }

    /// <summary>
    /// Delete a contact
    /// </summary>
    /// <param name="id">id of contact</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ContactDeleteResponse"/></returns>
    public async Task<ContactDeleteResponse> DeleteContact(
    string id, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await DeleteAsync<ContactDeleteResponse>(endpoint: $"contacts/{id}", 
                                                            parameters: null, 
                                                            cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can tag a specific contact. This will return a tag object for the tag that was added to the contact.
    /// </summary>
    /// <param name="id">contact id</param>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="TagResponse"/></returns>
    public async Task<TagResponse> AddTagToContact(
    string id,
    ContactAddTagRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<TagResponse>(endpoint: $"contacts/{id}/tags",
                                               parameters: null,
                                               cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    public async Task<TagResponse> RemoveTagFromContact(
    string contactId,
    string id,
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await DeleteAsync<TagResponse>(endpoint: $"contacts/{contactId}/tags/{id}",
                                                  parameters: null,
                                                  cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    public async Task<TagResponse> ContactTag(
    ContactTagRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await PostAsync<ContactTagRequest, TagResponse>(endpoint: $"tags",
                                                                   data: model,
                                                                   cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    #endregion
    #region Conversations

    /// <summary>
    /// You can tag a specific conversation. This will return a tag object for the tag that was added to the conversation.
    /// </summary>
    /// <param name="conversationId">conversation id</param>
    /// <param name="request">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="TagAddResponse"/></returns>
    public async Task<TagAddResponse> AddTagToConversation(
    string conversationId,
    ConversationAddTagRequest request,
    CancellationToken cancellationToken)
    {
        try
        {
            string url = $"conversations/{conversationId}/tags";
            return await PostAsync<object, TagAddResponse>(endpoint: url,
                                                           data: request,
                                                           cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// Remove tag from a conversation
    /// </summary>
    /// <param name="conversationId">conversation id</param>
    /// <param name="id">tag id</param>
    /// <param name="request">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="TagDeleteResponse"/></returns>
    public async Task<TagDeleteResponse> RemoveTagFromConversation(
    string conversationId,
    string id,
    ConversationRemoveTagRequest request,
    CancellationToken cancellationToken)
    {
        try
        {
            return await DeleteAsync<TagDeleteResponse>(endpoint: $"conversations/{conversationId}/tags/{id}", 
                                                        parameters: null, 
                                                        cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can fetch a list of all conversations.
    /// </summary>
    /// <param name="request">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ConversationListResponse"/></returns>
    public async Task<ConversationListResponse> ListAllConversations(
    PagesRequest request, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            var parameters = HttpHelper.ToSnakeCaseQueryStringAsDictionary<PagesRequest>(request);

            return await GetAsync<ConversationListResponse>(endpoint: "conversations", 
                                                            parameters: parameters, 
                                                            cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// Create a conversation
    /// </summary>
    /// <param name="request">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ConversationCreateResponse"/></returns>
    public async Task<ConversationCreateResponse> CreateConversation(
    ConversationCreateRequest request,
    CancellationToken cancellationToken)
    {
        try
        {
            return await PostAsync<ConversationCreateRequest, ConversationCreateResponse>(
                endpoint: "conversations",
                data: request,
                cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can fetch the details of a single conversation.
    /// </summary>
    /// <param name="id">id of the conversation</param>
    /// <param name="displayAs">display as</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ConversationResponse"/></returns>
    public async Task<ConversationResponse> RetrieveConversation(
    string id, 
    string displayAs = "plaintext",
    CancellationToken cancellationToken = default)
    {
        try
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("display_as", displayAs);

            return await GetAsync<ConversationResponse>(endpoint: $"conversations/{id}", 
                                                        parameters: parameters, 
                                                        cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// Update a conversation
    /// </summary>
    /// <param name="id">id of conversation</param>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ConversationResponse"/></returns>
    public async Task<ConversationResponse> UpdateConversation(
    string id,
    ConversationUpdateRequest model,
    CancellationToken cancellationToken)
    {
        try
        {
            return await PutAsync<ConversationUpdateRequest, ConversationResponse>(
                endpoint: $"conversations/{id}",
                data: model,
                cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can reply to a conversation with a message from an admin or on behalf of a contact, or with a note for admins.
    /// There are 3 types of contact reply : IntercomUserId, Email and UserId
    /// There are 1 type of admin reply : AdminId
    /// </summary>
    /// <param name="id">id of the conversation</param>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="ConversationReplyResponse"/></returns>
    public async Task<ConversationResponse> ReplyConversation(
    string id,
    ConversationReplyRequest model,
    CancellationToken cancellationToken)
    {
        try
        {
            return await PostAsync<ConversationReplyRequest, ConversationResponse>(
                endpoint: $"conversations/{id}/reply",
                data: model,
                cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    #endregion
    #region DataAttributes

    /// <summary>
    /// You can fetch a list of all data attributes belonging to a workspace for contacts, companies or conversations.
    /// </summary>
    /// <param name="request">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="DataAttributeListResponse"/></returns>
    public async Task<DataAttributeListResponse> ListAllDataAttributes(
    DataAttributeListRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            var parameters = HttpHelper.ToSnakeCaseQueryStringAsDictionary<DataAttributeListRequest>(model);

            return await GetAsync<DataAttributeListResponse>(endpoint: "data_attributes", 
                                                             parameters: parameters, 
                                                             cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can create a data attributes for a contact or a company.
    /// </summary>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="DataAttributeResponse"/></returns>
    public async Task<DataAttributeResponse> CreateDataAttribute(
    DataAttributeCreateRequest model,
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await PostAsync<DataAttributeCreateRequest, DataAttributeResponse>(
                endpoint: "data_attributes",
                data: model,
                cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can update a data attribute.
    /// Updating the data type is not possible
    /// It is currently a dangerous action to execute changing a data attribute's type via the API. You will need to update the type via the UI instead.
    /// </summary>
    /// <param name="id">id of data attribute</param>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="DataAttributeResponse"/></returns>
    public async Task<DataAttributeResponse> UpdateDataAttribute(
    int id, 
    DataAttributeUpdateRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await PutAsync<DataAttributeUpdateRequest, DataAttributeResponse>(
                endpoint: $"data_attributes/{id}",
                data: model,
                cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    #endregion
    #region DataEvents

    /// <summary>
    /// Submit a data event
    /// Limited the number of tracked metadata keys to 10 per event.
    /// </summary>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="bool"/></returns>
    public async Task<bool> SubmitDataEvent(
    DataEventSubmitRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            _ = await PostAsync<DataEventSubmitRequest, object>(endpoint: "events",
                                                                data: model,
                                                                cancellationToken: cancellationToken) != null;

            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return false;
        } 
    }

    /// <summary>
    /// The events belonging to a customer can be listed by sending a GET request to https://api.intercom.io/events with a user or lead identifier along with a type parameter. 
    /// The identifier parameter can be one of user_id, email or intercom_user_id. The type parameter value must be user
    /// Note that you can only 'list' events that are less than 90 days old. 
    /// Event counts and summaries will still include your events older than 90 days but you cannot 'list' these events individually if they are older than 90 days
    /// </summary>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="DataEventListResponse"/></returns>
    public async Task<DataEventListResponse> ListAllDataEvents(
    DataEventListRequest model,
    CancellationToken cancellationToken)
    {
        try
        {
            var parameters = HttpHelper.ToSnakeCaseQueryStringAsDictionary<DataEventListRequest>(model);

            return await GetAsync<DataEventListResponse>(endpoint: "events",
                                                         parameters: parameters,
                                                         cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    #endregion
    #region Messages

    // Message are how you reach out to contacts in Intercom.
    // They are created when an admin sends an outbound message to a contact.

    /// <summary>
    /// You can create a message that has been initiated by an admin. The conversation can be either an in-app message or an email.
    /// </summary>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="MessageCreateResponse"/></returns>
    public async Task<MessageCreateResponse> CreateMessage(
    MessageCreateRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await PostAsync<MessageCreateRequest, MessageCreateResponse>(endpoint: "messages",
                                                                                data: model,
                                                                                cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        } 
    }

    #endregion
    #region Segments

    // A segment is a group of your contacts defined by the rules that you set.

    /// <summary>
    /// You can fetch a list of segments that are associated to a contact.
    /// </summary>
    /// <param name="id">id of contact</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="SegmentListContactResponse"/></returns>
    public async Task<SegmentListContactResponse> ListContactAttachedSegments(
    string id,
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<SegmentListContactResponse>(endpoint: $"contacts/{id}/segments",
                                                      parameters: null,
                                                      cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can fetch a list of all segments.
    /// </summary>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="SegmentListResponse"/></returns>
    public async Task<SegmentListResponse> ListAllSegments(
    SegmentListRequest model,
    CancellationToken cancellationToken = default)
    {
        try
        {
            var parameters = HttpHelper.ToSnakeCaseQueryStringAsDictionary(model);

            return await GetAsync<SegmentListResponse>(endpoint: $"segments",
                                                       parameters: parameters,
                                                       cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can fetch the details of a single segment.
    /// </summary>
    /// <param name="id">id of segment</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="SegmentResponse"/></returns>
    public async Task<SegmentResponse> RetrieveSegment(
    string id, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<SegmentResponse>(endpoint: $"segments/{id}",
                                                   parameters: null,
                                                   cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    #endregion
    #region Tags
    // A tag allows you to label your contacts, companies, and conversations and list them using that tag.

    /// <summary>
    /// You can fetch a list of all tags that are attached to a specific contact.
    /// </summary>
    /// <param name="id">contact id</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="TagListResponse"/></returns>
    public async Task<TagListResponse> ListContactTags(
    string id, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<TagListResponse>(endpoint: $"contacts/{id}/tags",
                                                   parameters: null,
                                                   cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can fetch a list of all tags for a given workspace.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<TagListResponse> ListAllTags(
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<TagListResponse>(endpoint: $"tags",
                                                   parameters: null,
                                                   cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can create a new tag by passing in the tag name as specified
    /// </summary>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="TagResponse"/></returns>
    public async Task<TagResponse> CreateTag(
    TagCreateRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await PostAsync<TagCreateRequest, TagResponse>(endpoint: $"tags",
                                                                  data: model,
                                                                  cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    /// <summary>
    /// You can update an existing tag by passing the id of the tag as 
    /// specified in "Create or Update Tag Request Payload" described below.
    /// </summary>
    /// <param name="model">request model</param>
    /// <param name="cancellationToken">cancellation token</param>
    /// <returns><see cref="TagResponse"/></returns>
    public async Task<TagResponse> UpdateTag(
    TagUpdateRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await PostAsync<TagUpdateRequest, TagResponse>(endpoint: $"tags",
                                                                  data: model,
                                                                  cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    public async Task<TagResponse> RetrieveTag(
    string id, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await GetAsync<TagResponse>(endpoint: $"tags/{id}",
                                               parameters: null,
                                               cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    public async Task<bool> DeleteTag(
    string id, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            var response = await DeleteAsync<object>(endpoint: $"tags/{id}",
                                                     parameters: null,
                                                     cancellationToken: cancellationToken);

            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return false;
        }
    }

    #endregion
    #region Tickets
    public async Task<TagResponse> AddTagToTicket(
    string id, 
    TicketAddTagRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await PostAsync<TicketAddTagRequest, TagResponse>(endpoint: $"tickets/{id}/tags",
                                                                     data: model,
                                                                     cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    public async Task<TagResponse> RemoveTagFromTicket(
    string ticketId, 
    string tagId, 
    TicketRemoveTagRequest model, 
    CancellationToken cancellationToken = default)
    {
        try
        {
            return await DeleteAsync<TagResponse>(endpoint: $"tickets/{ticketId}/tags/{tagId}",
                                                  parameters: null,
                                                  cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError("An error occured on IntercomService", ex);
            return null;
        }
    }

    #endregion


    #region Private Methods
    private async Task<R> GetAsync<R>(
    string endpoint, 
    Dictionary<string, string> parameters = null,
    CancellationToken cancellationToken = default)
    {
        endpoint = await GetQueryStringUrl(parameters, endpoint);

        var response = await _httpClient.GetAsync(endpoint, cancellationToken);

        var responseString = await response.Content.ReadAsStringAsync();
        var result = Deserialize<R>(responseString);

        return result;
    }

    private async Task<R> PostAsync<T,R>(
    string endpoint, 
    T data,
    CancellationToken cancellationToken = default) 
    where T : class
    where R : class
    {
        var dataStr = Serialize<T>(data);
        var content = new StringContent(dataStr, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(endpoint, content, cancellationToken);

        var responseString = await response.Content.ReadAsStringAsync();
        var result = Deserialize<R>(responseString);

        return result;
    }

    private async Task<R> PutAsync<T,R>(
    string endpoint, 
    T data, 
    CancellationToken cancellationToken = default) 
    where T : class
    where R : class
    {
        var dataStr = Serialize<T>(data);
        var content = new StringContent(dataStr, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync(endpoint, content, cancellationToken);

        var responseString = await response.Content.ReadAsStringAsync();
        var result = Deserialize<R>(responseString);

        return result;
    }

    private async Task<R> DeleteAsync<R>(
    string endpoint, 
    Dictionary<string, string> parameters = null,
    CancellationToken cancellationToken = default)
    {
        endpoint = await GetQueryStringUrl(parameters, endpoint);

        var response = await _httpClient.DeleteAsync(endpoint, cancellationToken);
        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();
        var result = Deserialize<R>(responseString);

        return result;
    }

    private string Serialize<T>(T data) where T : class
    {
        return JsonConvert.SerializeObject(data, typeof(T), Formatting.None, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            }
        });
    }

    private T? Deserialize<T>(string data)
    {
        return JsonConvert.DeserializeObject<T>(data, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            }
        });
    }

    private async Task<string> GetQueryStringUrl(
    Dictionary<string, string> parameters,
    string endpoint)
    {
        if (parameters != null && parameters.Count > 0)
        {
            var queryString = await new FormUrlEncodedContent(parameters).ReadAsStringAsync();
            endpoint = $"{endpoint}?{queryString}";
        }

        return endpoint;
    }

    #endregion
}