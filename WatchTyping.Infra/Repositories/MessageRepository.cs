using Firebase.Database;
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
            _firebaseClient = new FirebaseClient(@"https://watchtyping.firebaseio.com/");
        }

        public Task SaveMessageAsync(Message message)
        {
            return _firebaseClient.Child("message").PostAsync(message.ToJson());
        }
    }
}
