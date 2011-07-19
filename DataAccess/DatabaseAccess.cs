using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Interfaces;
using Interfaces.Database;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Objects.Database;

namespace DataAccess
{
    public class DatabaseAccess : IDatabaseAccess
    {
        public IDatabaseConfiguration Configuration { get; set; }

        public DatabaseAccess(DatabaseConfiguration config)
        {
            Configuration = config;
        }

        private static string GetCollectionNameFromType(Type objectType)
        {

            var field = objectType.GetProperty("Collection", BindingFlags.Public | BindingFlags.Static);

            if (field != null)
            {
                return ((CollectionName)field.GetValue(null, null)).ToString();
            }

            return string.Empty;
        }


        public void SaveOne<T>(T objectToSave) where T : CollectionBase
        {
            var server = MongoServer.Create(Configuration.Server);

            MongoDatabase db = server.GetDatabase(Configuration.DatabaseName);

            var collectionName = GetCollectionNameFromType(typeof(T));

            var collection = db.GetCollection<T>(collectionName);

            collection.Save(objectToSave);
        }


        public void SaveMany<T>(List<T> objectsToSave) where T : CollectionBase
        {
            foreach (var t in objectsToSave)
            {
                SaveOne(t);
            }
        }

        public T GetSingle<T>(string friendlyId) where T : CollectionBase
        {
            var server = MongoServer.Create(Configuration.Server);

            MongoDatabase db = server.GetDatabase(Configuration.DatabaseName);

            var collectionName = GetCollectionNameFromType(typeof(T));

            var collection = db.GetCollection<T>(collectionName);

            var query = Query.EQ("FriendlyId", friendlyId);

            var objects = collection.Find(query);

            return objects.FirstOrDefault();
        }

        public List<T> GetAll<T>() where T : CollectionBase
        {
            var server = MongoServer.Create(Configuration.Server);

            MongoDatabase db = server.GetDatabase(Configuration.DatabaseName);

            var collectionName = GetCollectionNameFromType(typeof(T));

            var collection = db.GetCollection<T>(collectionName.ToString());

            var objects = collection.FindAll();

            return objects.ToList();
        }


    }
}
