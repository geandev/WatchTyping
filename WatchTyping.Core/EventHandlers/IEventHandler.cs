using System.Threading.Tasks;
using WatchTyping.Core.Events;

namespace WatchTyping.Core.EventHandlers
{
    public interface IEventHandler<TEvent>
        where TEvent : IEvent
    {
        Task HandleAsync(TEvent @event);
    }
}
