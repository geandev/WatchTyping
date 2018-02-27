using System.Threading.Tasks;
using System.Windows.Input;

namespace WatchTyping.Core.CommandHandlers
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Task ExecuteAsync(TCommand command);
    }
}
