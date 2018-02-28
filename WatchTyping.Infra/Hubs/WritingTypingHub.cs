using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using WatchTyping.Core.CommandHandlers;

namespace WatchTyping.Infra.Hubs
{
    public class WritingTypingHub : Hub
    {
        private readonly IUserWritingTextCommandHandler _handler;

        public WritingTypingHub(IUserWritingTextCommandHandler handler)
        {
            _handler = handler;
        }

        public Task SendAsync(string message)
        {
            return _handler.ExecuteAsync(new Core.Commands.UserWritingTextCommand { Message = message });
        }
    }
}
