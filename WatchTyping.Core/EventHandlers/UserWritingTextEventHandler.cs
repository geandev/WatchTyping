using System.Threading;
using System.Threading.Tasks;
using WatchTyping.Core.Events;
using WatchTyping.Core.Services;

namespace WatchTyping.Core.EventHandlers
{
    public class UserWritingTextEventHandler : IEventHandler<UserWritingTextEvent, UserWritingTextEvent>
    {
        public Task<UserWritingTextEvent> Handle(UserWritingTextEvent message, CancellationToken cancellationToken)
        {
            return Task.FromResult(message);
        }
    }
}
