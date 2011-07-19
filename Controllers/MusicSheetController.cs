using DataAccess;
using Objects.Database;

namespace Controllers
{
    public class MusicSheetController
    {
        public MusicSheet GetMusicSheetByFriendlyId(string friendlyId)
        {
            var config = new DatabaseConfiguration("mongodb://MusicCatalog:Password@staff.mongohq.com:10013/") { DatabaseName = "MusicCatalog" };

            var databaseAccess = new DatabaseAccess(config);

            var sheet = databaseAccess.GetSingle<MusicSheet>(friendlyId);

            return sheet;
        }

        public void InsertMusicSheet(MusicSheet sheet)
        {
            var config = new DatabaseConfiguration("mongodb://MusicCatalog:Password@staff.mongohq.com:10013/") { DatabaseName = "MusicCatalog" };

            var databaseAccess = new DatabaseAccess(config);

            databaseAccess.SaveOne(sheet);
        }
    }
}
