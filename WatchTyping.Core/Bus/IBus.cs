using System.Threading.Tasks;
using WatchTyping.Core.Events;

namespace WatchTyping.Core.Bus
{
    public interface IBus
    {
        Task<TResponse> RaiseEventAsync<TResponse>(IEvent<TResponse> @event);
    }
}
