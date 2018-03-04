using System.Threading;
using System.Threading.Tasks;
using WatchTyping.Core.Events;
using WatchTyping.Core.Services;

namespace WatchTyping.Core.EventHandlers
{
    public class UserCreateNewPaperEventHandler : IEventHandler<UserCreateNewPaperEvent>
    {
        private readonly IHubService _hub;

        public UserCreateNewPaperEventHandler(IHubService hub)
        {
            _hub = hub;
        }

        public async Task Handle(UserCreateNewPaperEvent notification, CancellationToken cancellationToken)
        {
            await _hub.NotifyUserCreateNewPaperAsync(notification);
        }
    }
}
