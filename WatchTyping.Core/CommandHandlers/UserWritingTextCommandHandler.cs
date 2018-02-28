using System;
using System.Threading.Tasks;
using WatchTyping.Core.Bus;
using WatchTyping.Core.Commands;
using WatchTyping.Core.Events;

namespace WatchTyping.Core.CommandHandlers
{
    public class UserWritingTextCommandHandler : IUserWritingTextCommandHandler
    {
        private readonly IBus _bus;

        public UserWritingTextCommandHandler(IBus bus)
        {
            _bus = bus;
        }

        public Task ExecuteAsync(UserWritingTextCommand command)
        {
            return _bus.RaiseEventAsync(new UserWritingTextEvent { Id = Guid.NewGuid(), Message = command.Message });
        }
    }
}
