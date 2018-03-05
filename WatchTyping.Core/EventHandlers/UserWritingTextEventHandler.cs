using System.Threading;
using System.Threading.Tasks;
using WatchTyping.Core.Events;
using WatchTyping.Core.Services;

namespace WatchTyping.Core.EventHandlers
{
    public class UserWritingTextEventHandler : IEventHandler<UserWritingTextEvent>
    {
        private readonly IHubService _hubService;

        public UserWritingTextEventHandler(IHubService hubService)
        {
            _hubService = hubService;
        }

        public async Task Handle(UserWritingTextEvent message, CancellationToken cancellationToken)
        {
            await _hubService.NotifyUserWritingTextAsync(message);
        }
    }
}
