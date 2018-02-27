using System.Threading.Tasks;
using WatchTyping.Core.Events;

namespace WatchTyping.Core.EventHandlers
{
    class UserWritingTextEventHandler : IEventHandler<UserWritingTextEvent>
    {
        public Task HandleAsync(UserWritingTextEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
