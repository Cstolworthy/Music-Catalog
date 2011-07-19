using System.Runtime.Serialization;
using MongoDB.Bson;

namespace Interfaces.Database
{
    [DataContract]
    public abstract class CollectionBase
    {
        [DataMember]
        public abstract BsonObjectId Id { get; set; }

        [DataMember]
        public abstract string FriendlyId { get; set; }
        public static CollectionName Collection { get; set; }
    }
}
