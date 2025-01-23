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
    // Admins are teammate accounts that have access to a workspace.


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
    // Companies allow you to represent organizations using your product.
    // Each company will have its own description and be associated with contacts. You can fetch, create, update and list companies.

    [HttpGet("list-all-companies")]
    public async Task<IActionResult> ListAllCompanies(
    [FromQuery] PagesRequest request,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.ListAllCompanies(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost("tag-company")]
    public async Task<IActionResult> TagCompanies(
    [FromBody] CompanyTagRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.TagCompany(request, cancellationToken);
        return Ok(response);
    }
    #endregion
    #region Contacts
    // Contact are the objects that represent your leads and users in Intercom.


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

    [HttpPost("add-tag-to-contact/{id}")]
    public async Task<IActionResult> AddTagToContact(
    string id,
    [FromBody] ContactAddTagRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.AddTagToContact(id, request, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("remove-tag-from-contact/{contactId}/{id}")]
    public async Task<IActionResult> RemoveTagFromContact(
    string contactId,
    string id,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.RemoveTagFromContact(contactId, id, cancellationToken);
        return Ok(response);
    }

    [HttpPost("tag-contact")]
    public async Task<IActionResult> TagContact(
    [FromBody] ContactTagRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ContactTag(request, cancellationToken);
        return Ok(response);
    }

    #endregion
    #region Conversations
    // Conversations are how you can communicate with users in Intercom.
    // They are created when a contact replies to an outbound message, or when one admin directly sends a message to a single contact.


    [HttpPost("add-tag-to-conversation/{conversationId}")]
    public async Task<IActionResult> AddTagToConversation(
    string conversationId,
    [FromBody] ConversationAddTagRequest model,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.AddTagToConversation(conversationId, model, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("remove-tag-from-conversation/{conversationId}/{id}")]
    public async Task<IActionResult> RemoveTagFromConversation(
    string conversationId,
    string id,
    [FromBody] ConversationRemoveTagRequest model,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.RemoveTagFromConversation(conversationId, id, model, cancellationToken);
        return Ok(response);
    }

    [HttpGet("list-all-conversations")]
    public async Task<IActionResult> ListAllConversations(
    [FromQuery] PagesRequest request,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.ListAllConversations(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("retrieve-conversation/{id}")]
    public async Task<IActionResult> RetrieveConversation(
    string id,
    string displayAs = "plaintext",
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.RetrieveConversation(id, displayAs, cancellationToken);
        return Ok(response);
    }


    [HttpPut("conversations/{id}")]
    public async Task<IActionResult> UpdateConversation(
    string id,
    ConversationUpdateRequest model,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.UpdateConversation(id, model, cancellationToken);
        return Ok(response);
    }

    [HttpPost("conversations/{id}/reply")]
    public async Task<IActionResult> ReplyConversation(
    string id,
    ConversationReplyRequest model,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ReplyConversation(id, model, cancellationToken);
        return Ok(response);
    }

    #endregion
    #region DataAttributes
    // Data Attributes are metadata used to describe your contact, company and conversation models.
    // These include standard and custom attributes. By using the data attributes endpoint,
    // you can get the global list of attributes for your workspace, as well as create and archive custom attributes.


    [HttpGet("list-all-data-attributes")]
    public async Task<IActionResult> ListAllDataAttributes(
    [FromQuery] DataAttributeListRequest request,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.ListAllDataAttributes(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost("create-data-attribute")]
    public async Task<IActionResult> CreateDataAttribute(
    [FromBody] DataAttributeCreateRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.CreateDataAttribute(request, cancellationToken);
        return Ok(response);
    }

    [HttpPut("update-data-attribute/{id}")]
    public async Task<IActionResult> UpdateDataAttribute(
    int id,
    [FromBody] DataAttributeUpdateRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.UpdateDataAttribute(id, request, cancellationToken);
        return Ok(response);
    }

    #endregion
    #region DataEvents
    /// Data events are used to notify Intercom of changes to your data.

    
    [HttpPost("submit-data-event")]
    public async Task<IActionResult> SubmitDataEvent(
    [FromBody] DataEventSubmitRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.SubmitDataEvent(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("list-all-data-events")]
    public async Task<IActionResult> ListAllDataEvents(
    [FromQuery] DataEventListRequest request,
    CancellationToken cancellationToken = default)
    {
        var response = await _intercomService.ListAllDataEvents(request, cancellationToken);
        return Ok(response);
    }

    #endregion
    #region Messages

    [HttpPost("create-message")]
    public async Task<IActionResult> CreateMessage(
    [FromBody] MessageCreateRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.CreateMessage(request, cancellationToken);
        return Ok(response);
    }

    #endregion
    #region Segments

    [HttpGet("list-contact-attached-segments/{id}")]
    public async Task<IActionResult> ListContactAttachedSegments(
    string id,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ListContactAttachedSegments(id, cancellationToken);
        return Ok(response);
    }

    [HttpGet("list-all-segments")]
    public async Task<IActionResult> ListAllSegments(
    [FromQuery] SegmentListRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ListAllSegments(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("retrieve-segment/{id}")]
    public async Task<IActionResult> RetrieveSegment(
    string id,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.RetrieveSegment(id, cancellationToken);
        return Ok(response);
    }

    #endregion
    #region Tags

    [HttpGet("list-contact-tags")]
    public async Task<IActionResult> ListContactTags(
    string id,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ListContactTags(id, cancellationToken);
        return Ok(response);
    }

    [HttpGet("list-all-tags")]
    public async Task<IActionResult> ListAllTags(
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ListAllTags(cancellationToken);
        return Ok(response);
    }

    [HttpPost("create-tag")]
    public async Task<IActionResult> CreateTag(
    [FromBody] TagCreateRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.CreateTag(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost("update-tag")]
    public async Task<IActionResult> UpdateTag(
    [FromBody] TagUpdateRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.UpdateTag(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("retrieve-tag/{id}")]
    public async Task<IActionResult> RetrieveTag(
    string id,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.RetrieveTag(id, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("delete-tag/{id}")]
    public async Task<IActionResult> DeleteTag(
    string id,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.DeleteTag(id, cancellationToken);
        return Ok(response);
    }

    #endregion
    #region TicketTypes

    [HttpGet("list-all-ticket-types")]
    public async Task<IActionResult> ListAllTicketTypes(
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ListAllTicketTypes(cancellationToken);
        return Ok(response);
    }

    [HttpPost("create-ticket-type")]
    public async Task<IActionResult> CreateTicketType(
    [FromBody] TicketTypeCreateRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.CreateTicketType(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("retrieve-ticket-type/{id}")]
    public async Task<IActionResult> RetrieveTicketType(
    string id,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.RetrieveTicketType(id, cancellationToken);
        return Ok(response);
    }

    [HttpPut("update-ticket-type/{id}")]
    public async Task<IActionResult> UpdateTicketType(
    string id,
    [FromBody] TicketTypeUpdateRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.UpdateTicketType(id, request, cancellationToken);
        return Ok(response);
    }

    #endregion
    #region Tickets

    [HttpPost("add-tag-to-ticket/{id}")]
    public async Task<IActionResult> AddTagToTicket(
    string id,
    [FromBody] TicketAddTagRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.AddTagToTicket(id, request, cancellationToken);
        return Ok(response);
    }

    [HttpDelete("remove-tag-from-ticket/{ticketId}/{tagId}")]
    public async Task<IActionResult> RemoveTagFromTicket(
    string ticketId,
    string tagId,
    [FromBody] TicketRemoveTagRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.RemoveTagFromTicket(ticketId, tagId, request, cancellationToken);
        return Ok(response);
    }

    [HttpPost("create-ticket")]
    public async Task<IActionResult> CreateTicket(
    [FromBody] TicketCreateRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.CreateTicket(request, cancellationToken);
        return Ok(response);
    }

    [HttpPut("update-ticket/{id}")]
    public async Task<IActionResult> UpdateTicket(
    string id,
    [FromBody] TicketUpdateRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.UpdateTicket(id, request, cancellationToken);
        return Ok(response);
    }

    [HttpPut("reply-to-ticket/{id}")]
    public async Task<IActionResult> ReplyToTicket(
    string id,
    [FromBody] TicketReplyRequest request,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.ReplyToTicket(id, request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("retrieve-ticket/{id}")]
    public async Task<IActionResult> RetrieveTicket(
    string id,
    CancellationToken cancellationToken)
    {
        var response = await _intercomService.RetrieveTicket(id, cancellationToken);
        return Ok(response);
    }

    #endregion
}
