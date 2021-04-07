using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Presensi_BLE_Beacon_UAJY.API.Models
{
    public class LoginMahasiswaViewModel
    {
        [Required]
        public string NPM { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
