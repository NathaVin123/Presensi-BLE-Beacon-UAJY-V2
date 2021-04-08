namespace Presensi_BLE_Beacon_UAJY.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

   public  class RecoverPasswordRequest
    {
        [Required]
        public string NPM { get; set; }
    }
}
