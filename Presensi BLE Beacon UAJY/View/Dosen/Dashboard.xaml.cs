using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Presensi_BLE_Beacon_UAJY.View.Dosen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : TabbedPage
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void AccountToDetail(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountDetailPage());
        }

        private async void AccountToAbout(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tentang_Aplikasi.AboutPage());
        }

        private async void AccountToStatistic(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Statistik.StatisticPage());
        }

        private async void AccountToSetting(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pengaturan.SettingsPage());
        }

        private async void ToLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login.LoginPage());
        }

        private async void ClassToDetail(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dosen.ClassDetailPage());
        }

        private async void ClassToHistory(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Dosen.HistoryDetailPage());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}