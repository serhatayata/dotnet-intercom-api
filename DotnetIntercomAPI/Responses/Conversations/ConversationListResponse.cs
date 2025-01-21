using DotnetIntercomAPI.Models.BaseModels;
using DotnetIntercomAPI.Models.Conversations;

namespace DotnetIntercomAPI.Responses.Conversations;

public class ConversationListResponse : BaseResponse
{
    public int TotalCount { get; set; }
    public PagesModel Pages { get; set; }
    public List<ConversationModel> Conversations { get; set; }
}
