using System.Threading.Tasks;

namespace SimpleBotCore.Repositories;

public interface IBotConversationLogRepository<TEvent> where TEvent : new()
{
    Task RegisterEventAsync(TEvent @event);
}
