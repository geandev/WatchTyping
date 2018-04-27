using System.Threading.Tasks;
using WatchTyping.Core.Commands;

namespace WatchTyping.Core.CommandHandlers
{
    public interface ICommandHandler<TCommand, TResponse>
        where TCommand : ICommand
    {
        Task<TResponse> ExecuteAsync(TCommand command);
    }
}
