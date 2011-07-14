using System.Collections.Generic;
using Interfaces.Database;

namespace DataAccess
{
    public interface IDatabaseAccess
    {
        IDatabaseConfiguration Configuration { get; set; }
        void SaveOne<T>(T objectToSave) where T : CollectionBase;
        void SaveMany<T>(List<T> objectsToSave) where T : CollectionBase;
        T GetSingle<T>(string friendlyId) where T : CollectionBase;
        List<T> GetAll<T>() where T : CollectionBase;
    }
}