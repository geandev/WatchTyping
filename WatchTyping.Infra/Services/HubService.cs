using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using WatchTyping.Core.Services;
using WatchTyping.Infra.Hubs;

namespace WatchTyping.Infra.Services
{
    public class HubService : IHubService
    {
        private readonly IHubContext<WritingTypingHub> _hub;

        public HubService(IHubContext<WritingTypingHub> hub)
        {
            _hub = hub;
        }

        public Task SendAsync(string message)
        {
            return _hub.Clients.All.SendAsync("send", message);
        }
    }
}
