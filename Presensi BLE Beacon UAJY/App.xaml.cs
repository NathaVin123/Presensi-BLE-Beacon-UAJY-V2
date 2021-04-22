using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Presensi_BLE_Beacon_UAJY.View;
using Presensi_BLE_Beacon_UAJY.Helpers;
using Presensi_BLE_Beacon_UAJY.Services;

namespace Presensi_BLE_Beacon_UAJY
{
    public partial class App : Application
    {
        public static AuthManager AuthManager { get; private set; }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new View.Login.SplashScreen());
            AuthManager = new AuthManager(new LoginMahasiswaService());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}