using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using WatchTyping.Core.Services;

namespace WatchTyping.Infra.Services
{
    public class SignalRHubService : Hub, IHubService
    {
        public Task SendAsync(string message)
        {
            return Clients.All.SendAsync("send", message);
        }
    }
}
