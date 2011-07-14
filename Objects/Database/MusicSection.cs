using Interfaces;
using Interfaces.Database;
using MongoDB.Bson;

namespace Objects.Database
{
    public class MusicSection : CollectionBase
    {
        public new static CollectionName Collection { get { return CollectionName.MusicalSection; } }
        public override BsonObjectId Id { get; set; }
        public override string FriendlyId { get; set; }
    }
}
