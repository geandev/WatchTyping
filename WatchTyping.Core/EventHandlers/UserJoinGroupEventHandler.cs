using System.Threading;
using System.Threading.Tasks;
using WatchTyping.Core.Events;
using WatchTyping.Core.Services;

namespace WatchTyping.Core.EventHandlers
{
    public class UserJoinGroupEventHandler : IEventHandler<UserJoinGroupEvent>
    {
        private readonly IHubService _hub;

        public UserJoinGroupEventHandler(IHubService hub)
        {
            _hub = hub;
        }

        public async Task Handle(UserJoinGroupEvent notification, CancellationToken cancellationToken)
        {
            await _hub.NotifyUserJoinGroupAsync(notification);
        }
    }
}
