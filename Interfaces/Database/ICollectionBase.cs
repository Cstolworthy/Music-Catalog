using MongoDB.Bson;

namespace Interfaces.Database
{
    public interface ICollectionBase
    {
        BsonObjectId Id { get; set; }
        string FriendlyId { get; set; }
        CollectionName Collection { get; set; }
    }
}
