using System;
using Interfaces;
using Interfaces.Database;
using MongoDB.Bson;

namespace Objects.Database
{
    public class MusicSheet : CollectionBase
    {
        public new static CollectionName Collection { get { return CollectionName.SheetMusic; } }
        public string Title { get; set; }
        public override BsonObjectId Id { get; set; }
        public override string FriendlyId { get; set; }
    }
}
