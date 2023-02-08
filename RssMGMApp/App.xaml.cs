using System.Windows;

namespace RssMGMApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly string SyncfusionKey =$"MTA4ODA0NkAzMjMwMmUzNDJlMzBZMmlDeUxZN09NbHpreE1TZHZuc3pDcnpVci9tczc3VmdqZ2lzTG9KVUxBPQ==";
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(SyncfusionKey);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow();
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
