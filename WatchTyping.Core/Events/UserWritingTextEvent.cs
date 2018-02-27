using System;

namespace WatchTyping.Core.Events
{
    public class UserWritingTextEvent : IEvent
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
    }
}
