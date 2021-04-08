using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Presensi_BLE_Beacon_UAJY.API.Data.Entities
{
    public class User : IdentityUser
    {
        public string NPM { get; set; }

        public string KD_CALON { get; set; }

        public string ID_PRODI { get; set; }

        public int ID_KONSENTRASI { get; set; }

        public string NOMHS { get; set; }

        public string NAMA_MHS { get; set; }

        public string JNS_KEL { get; set; }

        public string TMP_LAHIR { get; set; }

        public string PASSWORD { get; set; }

        public string KD_STATUS_MHS { get; set; }

        public string NPP_PEMBIMBING_AKADEMIK { get; set; }

        public string ALAMAT { get; set; }

        public string PASSWORD2 { get; set; }

        public int ID_PROGRAM { get; set; }

        public int ID_ORTU { get; set; }

        public string PASSWORD_ORTU { get; set; }

        //public int CityId { get; set; }

        //public City City { get; set; }
    }
}
