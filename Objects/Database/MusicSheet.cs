using System;
using Interfaces;
using Interfaces.Database;
using MongoDB.Bson;

namespace Objects.Database
{
    public class MusicSheet : ICollectionBase
    {
        public BsonObjectId Id
        {
            get;
            set;
        }

        public string FriendlyId { get; set; }
        public CollectionName Collection { get; set; }
        public string Title { get; set; }
    }
}
