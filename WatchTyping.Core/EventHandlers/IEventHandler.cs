using MediatR;

namespace WatchTyping.Core.EventHandlers
{
    public interface IEventHandler<in TEvent> : INotificationHandler<TEvent>
        where TEvent : INotification
    {
    }
}
