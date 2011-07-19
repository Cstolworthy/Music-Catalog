using System.Runtime.Serialization;
using Interfaces.Database;
using MongoDB.Bson;

namespace Objects.Database
{
    [DataContract] 
    public class Tag : CollectionBase
    {
        [DataMember]
        public override BsonObjectId Id { get; set; }

        [DataMember]
        public override string FriendlyId { get; set; }
    }
}
