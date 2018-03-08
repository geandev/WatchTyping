using System.Threading.Tasks;
using WatchTyping.Core.Models;

namespace WatchTyping.Core.Repositories
{
    public interface IMessageRepository
    {
        Task UpdateMessageAsync(string code, Message message);
        Task<Message> GetLastMessage(string code);
        Task<string> CreateMessageAsync();
    }
}
