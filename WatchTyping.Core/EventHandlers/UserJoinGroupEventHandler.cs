using System.Threading;
using System.Threading.Tasks;
using WatchTyping.Core.Events;
using WatchTyping.Core.Services;

namespace WatchTyping.Core.EventHandlers
{
    public class UserJoinGroupEventHandler : IEventHandler<UserJoinGroupEvent, UserJoinGroupEvent>
    {
        public Task<UserJoinGroupEvent> Handle(UserJoinGroupEvent notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(notification);
        }
    }
}
