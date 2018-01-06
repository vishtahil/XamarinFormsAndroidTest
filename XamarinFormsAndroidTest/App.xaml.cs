using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace XamarinFormsAndroidTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XamarinFormsAndroidTestPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            //AppCenter.Start("android=82fafe4c-2ce8-429f-b536-d77a3b04382c;" + "uwp={Your UWP App secret here};" +
                   //"ios={Your iOS App secret here}",
                   //typeof(Analytics), typeof(Crashes));
            AppCenter.Start("ios=2acf5f76-f998-4187-8ba3-48c12687d1cd;" + "uwp={Your UWP App secret here};" +
                   "android={Your Android App secret here}",
                   typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
