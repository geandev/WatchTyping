using WatchTyping.Core.Commands;
using WatchTyping.Core.Events;

namespace WatchTyping.Core.CommandHandlers
{
    public interface IUserCreateNewPaperCommandHandler : ICommandHandler<UserCreateNewPaperCommand, UserCreateNewPaperEvent>
    {
    }
}
