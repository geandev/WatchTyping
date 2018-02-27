using System.Threading;
using System.Threading.Tasks;
using WatchTyping.Core.Events;

namespace WatchTyping.Core.EventHandlers
{
    public class UserWritingTextEventHandler : IEventHandler<UserWritingTextEvent>
    {
        public Task Handle(UserWritingTextEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
