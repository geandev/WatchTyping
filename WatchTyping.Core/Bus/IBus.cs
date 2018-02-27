using System.Threading.Tasks;
using WatchTyping.Core.Events;

namespace WatchTyping.Core.Bus
{
    public interface IBus
    {
        Task RaiseEventAsync(IEvent @event);
    }
}
