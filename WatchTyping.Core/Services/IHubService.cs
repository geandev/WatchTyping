using System.Threading.Tasks;
using WatchTyping.Core.Events;

namespace WatchTyping.Core.Services
{
    public interface IHubService
    {
        Task NotifyUserCreateNewPaperAsync(UserCreateNewPaperEvent @event);
        Task NotifyUserCreateNewPaperAsync(UserCreateNewPaperEvent @event);
    }
}
