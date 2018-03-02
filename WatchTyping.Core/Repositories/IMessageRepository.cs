using System.Threading.Tasks;
using WatchTyping.Core.Models;

namespace WatchTyping.Core.Repositories
{
    public interface IMessageRepository
    {
        Task SaveMessageAsync(Message message);
    }
}
