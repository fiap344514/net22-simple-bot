using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace SimpleBotCore.Repositories;

internal class BotConversationLogMongoRepository : IBotConversationLogRepository<BsonDocument>
{
    private const string CollectionName = "BotConversationLog";

    private readonly IMongoCollection<BsonDocument> _collection;

    public BotConversationLogMongoRepository(IMongoDatabase database)
        => _collection = database.GetCollection<BsonDocument>(CollectionName);

    public async Task RegisterEventAsync(BsonDocument @event)
        => await _collection.InsertOneAsync(@event);
}
