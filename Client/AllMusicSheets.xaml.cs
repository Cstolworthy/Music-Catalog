using System.Windows.Controls;

namespace Client
{
    /// <summary>
    /// Interaction logic for AllMusicSheets.xaml
    /// </summary>
    public partial class AllMusicSheets : Page
    {
        public AllMusicSheets()
        {
            InitializeComponent();
        }

        public override void BeginInit()
        {

            this.DataContext = new MusicSheetDataService.MusicSheetDataServiceClient();
            base.BeginInit();
        }
    }
}
