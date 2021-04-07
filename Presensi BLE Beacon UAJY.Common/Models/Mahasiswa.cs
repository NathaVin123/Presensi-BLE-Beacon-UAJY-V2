using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Presensi_BLE_Beacon_UAJY.Common.Models
{
    class Mahasiswa
    {
        [JsonProperty("npm")]
        public string NPM { get; set; }

        [JsonProperty("kdCalon")]
        public string KD_CALON { get; set; }

        //[JsonProperty("idFakultas")]
        //public int ID_FAKULTAS { get; set; }

        [JsonProperty("idProdi")]
        public string ID_PRODI { get; set; }

        [JsonProperty("idKonsentrasi")]
        public int ID_KONSENTRASI { get; set; }

        [JsonProperty("noMhs")]
        public string NOMHS { get; set; }

        [JsonProperty("namaMhs")]
        public string NAMA_MHS { get; set; }

        //[JsonProperty("thnMasuk")]
        //public int THN_MASUK { get; set; }

        [JsonProperty("jnsKel")]
        public string JNS_KEL { get; set; }

        [JsonProperty("tmpLahir")]
        public string TMP_LAHIR { get; set; }

        //[JsonProperty("tglLahir")]
        //public DateTime TGL_LAHIR { get; set; }

        [JsonProperty("password")]
        public string PASSWORD { get; set; }

        [JsonProperty("kdStatusMhs")]
        public string KD_STATUS_MHS { get; set; }

        [JsonProperty("nppPembimbingAkademik")]
        public string NPP_PEMBIMBING_AKADEMIK { get; set; }

        //[JsonProperty("isMasukMiddle")]
        //public bool ISMASUKMIDDLE { get; set; }

        [JsonProperty("alamat")]
        public string ALAMAT { get; set; }

        //[JsonProperty("password1")]
        //public string PASSWORD1 { get; set; }

        [JsonProperty("password2")]
        public string PASSWORD2 { get; set; }

        [JsonProperty("idProgram")]
        public int ID_PROGRAM { get; set; }

        [JsonProperty("idOrtu")]
        public int ID_ORTU { get; set; }

        [JsonProperty("passwordOrtu")]
        public string PASSWORD_ORTU { get; set; }

        //[JsonProperty("isSudahKirim")]
        //public string IS_SUDAH_KIRIM { get; set; }
    }
}
