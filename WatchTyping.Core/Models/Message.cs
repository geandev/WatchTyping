using System;

namespace WatchTyping.Core.Models
{
    public class Message
    {
        public Guid Id { get; private set; }
        public string Text { get; private set; }

        private Message(Guid id, string text)
        {
            Id = id;
            Text = text;
        }

        public static Message CreateNew(Guid id, string text) => new Message(id, text);
    }
}
