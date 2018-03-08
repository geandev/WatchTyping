using System.Threading.Tasks;
using WatchTyping.Core.Bus;
using WatchTyping.Core.Commands;
using WatchTyping.Core.Events;
using WatchTyping.Core.Repositories;

namespace WatchTyping.Core.CommandHandlers
{
    public class UserJoinGroupCommandHandler : IUserJoinGroupCommandHandler
    {
        private readonly IBus _bus;
        private readonly IMessageRepository _messageRepository;

        public UserJoinGroupCommandHandler(
            IBus bus,
            IMessageRepository messageRepository
            )
        {
            _bus = bus;
            _messageRepository = messageRepository;
        }

        public async Task ExecuteAsync(UserJoinGroupCommand command)
        {
            var lastMessage = await _messageRepository.GetLastMessage(command.GroupId);
            await _bus.RaiseEventAsync(new UserJoinGroupEvent { ConnectionId = command.ConnectionId, GroupId = command.GroupId, LastMessage = lastMessage });
        }
    }
}
