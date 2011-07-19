using System;
using Controllers;
using Objects.Database;

namespace Webservices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MusicSheetDataService" in code, svc and config file together.
    public class MusicSheetDataService : IMusicSheetDataService
    {
        public MusicSheet GetMusicSheet(string friendlyId)
        {
            var msc = new MusicSheetController();
            return msc.GetMusicSheetByFriendlyId(friendlyId);
        }

        public void InsertMusicSheet(MusicSheet sheet)
        {
            var msc = new MusicSheetController();
            msc.InsertMusicSheet(sheet);
        }
    }
}
