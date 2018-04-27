using System.Threading;
using System.Threading.Tasks;
using WatchTyping.Core.Events;
using WatchTyping.Core.Services;

namespace WatchTyping.Core.EventHandlers
{
    public class UserCreateNewPaperEventHandler : IEventHandler<UserCreateNewPaperEvent, UserCreateNewPaperEvent>
    {
        public Task<UserCreateNewPaperEvent> Handle(UserCreateNewPaperEvent notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(notification);
        }
    }
}
