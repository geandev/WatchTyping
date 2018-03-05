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
        private readonly IUserJoinGroupCommandHandler _userJoinGroupCommandHandler;

        public WritingTypingHub(
            IUserCreateNewPaperCommandHandler userCreateNewPaperCommandHandler,
            IUserWritingTextCommandHandler userWritingTextCommandHandler,
            IUserJoinGroupCommandHandler userJoinGroupCommand
            )
        {
            _userCreateNewPaperCommandHandler = userCreateNewPaperCommandHandler;
            _userWritingTextCommandHandler = userWritingTextCommandHandler;
            _userJoinGroupCommandHandler = userJoinGroupCommand;
        }

        public async Task JoinGroupAsync(string groupId)
        {
            await _userJoinGroupCommandHandler.ExecuteAsync(new UserJoinGroupCommand { ConnectionId = Context.ConnectionId, GroupId = groupId });
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
