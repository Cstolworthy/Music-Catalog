﻿using System.Runtime.Serialization;
using Interfaces;
using Interfaces.Database;
using MongoDB.Bson;

namespace Objects.Database
{
    [DataContract]
    public class MusicSection : CollectionBase
    {
        public new static CollectionName Collection { get { return CollectionName.MusicalSection; } }

        [DataMember]
        public override BsonObjectId Id { get; set; }

        [DataMember]
        public override string FriendlyId { get; set; }
    }
}
