using System;

namespace WatchTyping.Core.Events
{
    public class UserWritingTextEvent : IEvent
    {
        public string ConnectionId { get; set; }
        public string GroupId { get; set; }
        public string Message { get; set; }
    }
}
