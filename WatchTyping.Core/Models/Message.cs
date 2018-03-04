using System;

namespace WatchTyping.Core.Models
{
    public class Message
    {
        public DateTime DateReceived { get; private set; }
        public string Text { get; private set; }

        public Message(DateTime dateReceived, string text)
        {
            DateReceived = dateReceived;
            Text = text;
        }

        public static Message CreateNew(DateTime dateReceived, string text) => new Message(dateReceived, text);
    }
}
