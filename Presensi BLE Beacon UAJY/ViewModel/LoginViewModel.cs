using System;
using System.Collections.Generic;
using System.Text;
using Presensi_BLE_Beacon_UAJY.Helpers;
using Presensi_BLE_Beacon_UAJY.Services;
using System.Windows.Input;
using Xamarin.Forms;

namespace Presensi_BLE_Beacon_UAJY.ViewModel
{
    public class LoginViewModel
    {
        private readonly APIService apiservice = new APIService();

        public string NPM { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var accesstoken = await apiservice.LoginAsync(NPM, Password);

                    Settings.AccessToken = accesstoken;
                });
            }
        }

        public LoginViewModel()
        {
            NPM = Settings.NPM;
            Password = Settings.Password;
        }
    }
}