using System.Threading.Tasks;
using WatchTyping.Core.Events;

namespace WatchTyping.Core.Services
{
    public interface IHubService
    {
        Task NotifyUserCreateNewPaperAsync(UserCreateNewPaperEvent @event);
        Task NotifyUserWritingTextAsync(UserWritingTextEvent @event);
        Task NotifyUserJoinGroupAsync(UserJoinGroupEvent @event);
    }
}
