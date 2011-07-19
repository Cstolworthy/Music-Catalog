using System.ServiceModel;
using Objects.Database;

namespace Webservices
{
    [ServiceContract]
    public interface IMusicSheetDataService
    {
        [OperationContract]
        MusicSheet GetMusicSheet(string friendlyId);

        [OperationContract]
        void InsertMusicSheet(MusicSheet sheet);
    }

}
