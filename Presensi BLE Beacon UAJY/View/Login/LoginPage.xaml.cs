using Presensi_BLE_Beacon_UAJY.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Presensi_BLE_Beacon_UAJY.View.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        //private async void LoginToDashboard(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (RolePicker.SelectedItem.ToString() == "Mahasiswa")
        //        {
        //            await Navigation.PushAsync(new Mahasiswa.Dashboard());
        //        }
        //        else
        //        if (RolePicker.SelectedItem.ToString() == "Dosen")
        //        {
        //            await Navigation.PushAsync(new Dosen.Dashboard());
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        await DisplayAlert("Gagal Login", "Anda belum memilih Role", "Oke");
        //    }
        //}

        private async void LoginToDashboard(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Settings.AccessToken))
                {
                    await Navigation.PushAsync(new Mahasiswa.Dashboard());
                }
            }
            catch (Exception)
            {
                await DisplayAlert("Gagal Login", "Anda belum memilih Role", "Oke");
            }
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}