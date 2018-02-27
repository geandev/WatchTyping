using System.Threading.Tasks;
using WatchTyping.Core.Commands;

namespace WatchTyping.Core.CommandHandlers
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Task ExecuteAsync(TCommand command);
    }
}
