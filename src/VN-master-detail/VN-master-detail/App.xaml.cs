using Interfaces;
using Stub;

namespace VN_master_detail
{
    public partial class App : Application
    {
        public readonly IDataManager DataManager = new DataManager(new NovelStub());
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
