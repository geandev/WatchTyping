using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using WatchTyping.Core.CommandHandlers;
using WatchTyping.Core.Commands;

namespace WatchTyping.Infra.Hubs
{
    public class WritingTypingHub : Hub<IWritingTypingHubClientFacade>
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
            var @event = await _userJoinGroupCommandHandler.ExecuteAsync(new UserJoinGroupCommand { ConnectionId = Context.ConnectionId, GroupId = groupId });

            await Groups.AddAsync(@event.ConnectionId, @event.GroupId);
            Clients.Client(@event.ConnectionId).UserJoinGroupEvent(@event.LastMessage?.Text);
        }

        public async Task CreateNewPaperAsync()
        {
            var @event = await _userCreateNewPaperCommandHandler.ExecuteAsync(new UserCreateNewPaperCommand { ConnectionId = Context.ConnectionId });

            await Groups.AddAsync(@event.ConnectionId, @event.GroupId);
            Clients.Group(@event.GroupId).UserCreateNewPaperEvent(@event.GroupId);
        }

        public async Task UpdateMessageAsync(string groupId, string message)
        {
            var @event = await _userWritingTextCommandHandler.ExecuteAsync(new UserWritingTextCommand { GroupId = groupId, Message = message, ConnectionId = Context.ConnectionId });

            await Groups.RemoveAsync(@event.ConnectionId, @event.GroupId);
            Clients.Group(@event.GroupId).UserWritingTextEvent(@event.Message);
            await Groups.AddAsync(@event.ConnectionId, @event.GroupId);
        }
    }
}
