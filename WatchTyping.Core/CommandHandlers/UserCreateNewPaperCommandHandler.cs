using System.Threading.Tasks;
using WatchTyping.Core.Bus;
using WatchTyping.Core.Commands;
using WatchTyping.Core.Events;
using WatchTyping.Core.Repositories;

namespace WatchTyping.Core.CommandHandlers
{
    public class UserCreateNewPaperCommandHandler : IUserCreateNewPaperCommandHandler
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IBus _bus;

        public UserCreateNewPaperCommandHandler(
            IMessageRepository messageRepository,
            IBus bus
            )
        {
            _messageRepository = messageRepository;
            _bus = bus;
        }

        public async Task<UserCreateNewPaperEvent> ExecuteAsync(UserCreateNewPaperCommand command)
        {
            var groupId = await _messageRepository.CreateMessageAsync();
            return await _bus.RaiseEventAsync(new UserCreateNewPaperEvent { ConnectionId = command.ConnectionId, GroupId = groupId });
        }
    }
}
