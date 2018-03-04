using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Threading.Tasks;
using WatchTyping.Core.Models;
using WatchTyping.Core.Repositories;
using WatchTyping.Infra.Ultilities;

namespace WatchTyping.Infra.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly FirebaseClient _firebaseClient;

        public MessageRepository()
        {
            _firebaseClient = new FirebaseClient($"https://watchtyping.firebaseio.com/");
        }

        public Task<string> CreateMessageAsync()
        {
            return _firebaseClient.Child(nameof(Message))
                .PostAsync(DateTime.Now)
                .ContinueWith(t => t.Result.Key);
        }

        public Task UpdateMessageAsync(string code, Message message)
        {
            return _firebaseClient.Child(nameof(Message)).Child(code).PostAsync(message.ToJson());
        }
    }
}
