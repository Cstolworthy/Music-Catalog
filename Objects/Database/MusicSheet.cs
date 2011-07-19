using System.Collections.Generic;
using System.Runtime.Serialization;
using Interfaces;
using Interfaces.Database;
using MongoDB.Bson;

namespace Objects.Database
{
    [DataContract]
    public class MusicSheet : CollectionBase
    {
        public new static CollectionName Collection { get { return CollectionName.SheetMusic; } }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public override BsonObjectId Id { get; set; }

        [DataMember]
        public override string FriendlyId { get; set; }

        [DataMember]
        public string Composer { get; set; }

        [DataMember]
        public List<MusicSection> Instruments { get; set; }

        [DataMember]
        public List<Tag> Tags { get; set; }
    }
}
