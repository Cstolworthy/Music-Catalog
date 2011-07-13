using System.Collections.Generic;
using System.Linq;
using Interfaces;
using Interfaces.Database;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Objects;
using Objects.Database;


namespace DataAccess
{
    public class DatabaseAccess
    {
        public DatabaseConfiguration Configuration { get; set; }

        public DatabaseAccess(DatabaseConfiguration config)
        {
            Configuration = config;
        }

        public void Save<T>(T objectToSave) where T : ICollectionBase
        {

            var server = MongoServer.Create(Configuration.Server);

            MongoDatabase db = server.GetDatabase(Configuration.DatabaseName);

            var collection = db.GetCollection<T>(objectToSave.Collection.ToString());

            collection.Save(objectToSave);
        }

        public T GetSingle<T>(CollectionName name, string friendlyId) where T : ICollectionBase
        {
            var server = MongoServer.Create(Configuration.Server);

            MongoDatabase db = server.GetDatabase(Configuration.DatabaseName);

            var collection = db.GetCollection<T>(name.ToString());

            var query = Query.EQ("FriendlyId", friendlyId);

            var objects = collection.Find(query);

            return objects.FirstOrDefault();
        }

        public List<T> GetAll<T>(CollectionName name) where T : ICollectionBase
        {
            var server = MongoServer.Create(Configuration.Server);

            MongoDatabase db = server.GetDatabase(Configuration.DatabaseName);

            var collection = db.GetCollection<T>(name.ToString());

            var objects = collection.FindAll();

            return objects.ToList();
        }
    }
}
