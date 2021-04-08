namespace Presensi_BLE_Beacon_UAJY.API.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class LoginViewModel
    {
        [Required]
        public string NPM { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
