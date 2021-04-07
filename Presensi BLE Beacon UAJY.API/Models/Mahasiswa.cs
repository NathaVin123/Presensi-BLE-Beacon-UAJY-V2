using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presensi_BLE_Beacon_UAJY.API.Models
{
    [Table("mst_mhs_aktif")]
    public class Mahasiswa
    {
        [Key]
        public string NPM
        {
            get;
            set;
        }

        public string NAMA_MHS
        {
            get;
            set;
        }

        public string TMP_LAHIR
        {
            get;
            set;
        }

        public string PASSWORD
        {
            get;
            set;
        }

        public string ALAMAT
        {
            get;
            set;
        }
    }
}