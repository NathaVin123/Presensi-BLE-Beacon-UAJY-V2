namespace Presensi_BLE_Beacon_UAJY.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class NewUserRequest
    {
        [Required]
        public string NPM { get; set; }
        public string NOMHS { get; set; }
        [Required]
        public string NAMA_MHS { get; set; }
        [Required]
        public string JNS_KEL { get; set; }
        [Required]
        public string TMP_LAHIR { get; set; }
        [Required]
        public string PASSWORD { get; set; }
        [Required]
        public string PASSWORD2 { get; set; }
    }
}
