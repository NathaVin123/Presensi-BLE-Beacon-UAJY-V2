using GalaSoft.MvvmLight.Command;
using Presensi_BLE_Beacon_UAJY.Common.Models;
using Presensi_BLE_Beacon_UAJY.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Presensi_BLE_Beacon_UAJY.ViewModels
{
    public class MainViewModel
    {

        #region Attributes

        #endregion

        #region Properties

        
        public TokenResponse Token { get; set; }
        public LoginViewModel Login { get; set; }
        
        public User User  { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        #endregion

        #region Contructor
        public MainViewModel()
        {
            //singleton:
            instance = this;

            //this.Login = new LoginViewModel();

            this.loadMenus();
        }


        #endregion

        #region Singleton

        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }

        #endregion

        #region Commands


        
        #endregion

        #region Methods
        private void loadMenus()
        {
            var menus = new List<Menu>
            {
                new Menu
                {
                    Icon = "ic_info",
                    PageName = "AboutPage",
                    Title = "About"
                },

                 new Menu
                {
                    Icon = "ic_person",
                    PageName = "ProfilePage",
                    Title = "Modify User"
                },


                new Menu
                {
                    Icon = "ic_phonelink_setup",
                    PageName = "SetupPage",
                    Title = "Setup"
                },

                new Menu
                {
                    Icon = "ic_exit_to_app.png",
                    PageName = "LoginPage",
                    Title = "Close Session"
                }


            };

           
        }

        


        #endregion

    }
}
