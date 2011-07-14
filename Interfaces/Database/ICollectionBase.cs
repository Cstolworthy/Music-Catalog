using MongoDB.Bson;

namespace Interfaces.Database
{
    public abstract class CollectionBase
    {
        public abstract BsonObjectId Id { get; set; }
        public abstract string FriendlyId { get; set; }
        public static CollectionName Collection { get; set; }
    }
}
