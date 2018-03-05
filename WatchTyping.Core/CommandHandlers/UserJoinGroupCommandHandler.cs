using System.Threading.Tasks;
using WatchTyping.Core.Bus;
using WatchTyping.Core.Commands;
using WatchTyping.Core.Events;

namespace WatchTyping.Core.CommandHandlers
{
    public class UserJoinGroupCommandHandler : IUserJoinGroupCommandHandler
    {
        private readonly IBus _bus;

        public UserJoinGroupCommandHandler(IBus bus)
        {
            _bus = bus;
        }

        public async Task ExecuteAsync(UserJoinGroupCommand command)
        {
            await _bus.RaiseEventAsync(new UserJoinGroupEvent { ConnectionId = command.ConnectionId, GroupId = command.GroupId });
        }
    }
}
