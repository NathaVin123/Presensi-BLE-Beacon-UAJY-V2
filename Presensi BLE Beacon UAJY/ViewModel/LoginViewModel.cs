using System.Windows.Input;
using Xamarin.Forms;
using Presensi_BLE_Beacon_UAJY.Models;
using Presensi_BLE_Beacon_UAJY.Helpers;


namespace Presensi_BLE_Beacon_UAJY.ViewModel
{
    public class LoginViewModel
    {
        public string NPM { get; set; }
        public string PASSWORD { get; set; }

        public LoginViewModel()
        {
            NPM = Settings.NPM;
            PASSWORD = Settings.PASSWORD;
        }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var model = new LoginMahasiswaModel
                    {
                        NPM = NPM,
                        PASSWORD = PASSWORD
                    };

                    // Authenticate user by calling LoginAsync service
                    await App.AuthManager.LoginAsync(model);

                    // If Token is returned after logging in, launch MasterDetailPage
                });
            }
        }
    }
}