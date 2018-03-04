using System;

namespace WatchTyping.Core.Events
{
    public class UserWritingTextEvent : IEvent
    {
        public string GroupId { get; set; }
        public string Message { get; set; }
    }
}
