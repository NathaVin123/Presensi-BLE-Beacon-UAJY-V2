namespace Presensi_BLE_Beacon_UAJY.ViewModel
{
    using GalaSoft.MvvmLight.Command;
    using Newtonsoft.Json;
    using Presensi_BLE_Beacon_UAJY.Common.Helpers;
    using Presensi_BLE_Beacon_UAJY.Common.Models;
    using Presensi_BLE_Beacon_UAJY.Common.Services;
    using Presensi_BLE_Beacon_UAJY.Helpers;
    using Presensi_BLE_Beacon_UAJY.ViewModels;
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Xamarin.Forms.Internals;
    using Xamarin.Forms.Xaml;

    public class LoginViewModel : BaseViewModels
    {

        #region Attributtes

        private readonly ApiService apiService;
        private bool isRunning;
        private bool isEnabled;
        private bool isRemember;

        #endregion
        #region Properties

        public string NPM { get; set; }
        public string Password { get; set; }
        public bool IsRemember
        {
            get => isRemember;
            set
            {
                if (isRemember != value)
                {
                    isRemember = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool IsRunning
        {
            get => isRunning;
            set
            {
                if (isRunning != value)
                {
                    isRunning = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                if (isEnabled != value)
                {
                    isEnabled = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Contructors

        public LoginViewModel()
        {
            //services
            this.apiService = new ApiService();

            //Boton
            this.IsEnabled = true;
            this.IsRemember = true;

            //Email = "angelina@gmail.com";
            //Password = "123456";
        }

        public ICommand LoginCommand { get => new RelayCommand(Login); }

        private async void Login()
        {
            try
            {
                if (string.IsNullOrEmpty(NPM))
                {

                    await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.EmailError, Languages.Accept);

                    return;
                }

                if (string.IsNullOrEmpty(Password))
                {
                    await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.PasswordError, Languages.Accept);

                    return;
                }


                //if (!Email.Equals("barrera_emilio@yahoo.es") || !Password.Equals("Eabs123."))
                //{

                //    await Application.Current.MainPage.DisplayAlert("Error", "User or Password wrong", "Accept");
                //    return;

                //}

                //await Application.Current.MainPage.DisplayAlert("Ok", "Fuck yearrrrr", "Accept"); 


                this.IsRunning = true;
                this.IsEnabled = false;

                //aqui ya consumo el token de seguridad:
                var request = new TokenRequest()
                {
                    Password = this.Password,
                    NPM = this.NPM,
                };

                //aqui me consumo la api:
                var UrlApi = Application.Current.Resources["UrlApi"].ToString();
                var UrlApiAccount = Application.Current.Resources["UrlApiAccount"].ToString();
                var UrlApiCreateToken = Application.Current.Resources["UrlApiCreateToken"].ToString();

                var response = await this.apiService.GetTokenAsync(UrlApi, UrlApiAccount, UrlApiCreateToken, request);

                this.IsRunning = false;
                this.IsEnabled = true;

                if (!response.IsSuccess)
                {
                    await Application.Current.MainPage.DisplayAlert(Languages.Error, Languages.LoginError, Languages.Accept);
                    return;
                }

                //aqui deserializo el token
                var token = (TokenResponse)response.Result;
                //var UrlAccountControllerGetUserByEmail = Application.Current.Resources["UrlAccountControllerGetUserByEmail"].ToString();
                //var Api = Application.Current.Resources["UrlApiProducts"].ToString();
                //var bearer = Application.Current.Resources["bearer"].ToString();

                var response2 = await this.apiService.GetUserByEmailAsync(
                                     UrlApi,
                                     "/api",
                                     "/Account/GetUserByEmail",
                                     this.NPM,
                                     "bearer",
                                     token.Token);

                var user = (User)response2.Result;

                var mainViewModel = MainViewModel.GetInstance();
                //aqui guardo toslo datos del usurio e persistencia y en el mainviewmodel, para todo el proyecto traido desde la api:
                mainViewModel.User = user;
                //aqui guardo el password y el usuario en memoria
                mainViewModel.UserEmail = this.NPM;
                mainViewModel.UserPassword = this.Password;
                //aqui guaro el toen en memoria:
                mainViewModel.Token = token;
                //Aqui intacion con el singleto del main  viewmodel:


                //aqui navego a la pagina de products y veo la llista de los mismos:
                //await Application.Current.MainPage.Navigation.PushAsync(new ProductsPage());      

                //aqui guaro loa credenciales e persistencia login y password ad token:
                Settings.UserEmail = this.NPM;
                Settings.UserPassword = this.Password;
                //aqui converto el token de object a string
                Settings.Token = JsonConvert.SerializeObject(token);
                //aqui gauro el usurio e persistencia comop un string:
                Settings.User = JsonConvert.SerializeObject(user);

                //despues del login arranca por el masterdetailpage

            }
            catch (Exception)
            {
                Log.Warning("Gagal Login","Terjadi Kesalahan");
            }



        }

        
        #endregion
    }
}
