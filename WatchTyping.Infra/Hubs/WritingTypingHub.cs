using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using WatchTyping.Core.CommandHandlers;
using WatchTyping.Core.Commands;

namespace WatchTyping.Infra.Hubs
{
    public class WritingTypingHub : Hub
    {
        private readonly IUserCreateNewPaperCommandHandler _userCreateNewPaperCommandHandler;
        private readonly IUserWritingTextCommandHandler _userWritingTextCommandHandler;

        public WritingTypingHub(
            IUserCreateNewPaperCommandHandler userCreateNewPaperCommandHandler,
            IUserWritingTextCommandHandler userWritingTextCommandHandler
            )
        {
            _userCreateNewPaperCommandHandler = userCreateNewPaperCommandHandler;
            _userWritingTextCommandHandler = userWritingTextCommandHandler;
        }

        public Task JoinGroupAsync()
        {
            return Task.CompletedTask;
        }

        public async Task CreateNewPaperAsync()
        {
            await _userCreateNewPaperCommandHandler.ExecuteAsync(new UserCreateNewPaperCommand { ConnectionId = Context.ConnectionId });
        }

        public async Task UpdateMessageAsync(string groupId, string message)
        {
            await _userWritingTextCommandHandler.ExecuteAsync(new UserWritingTextCommand { GroupId = groupId, Message = message });
        }
    }
}
