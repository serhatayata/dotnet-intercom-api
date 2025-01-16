using DotnetIntercomAPI.Models;
using DotnetIntercomAPI.Models.Contacts;
using Newtonsoft.Json;

namespace DotnetIntercomAPI.Responses.Contacts;

public class ContactListResponse : BaseResponse
{
    public List<ContactModel> Data { get; set; }
    public int TotalCount { get; set; }
    public PagesModel Pages { get; set; }
}
