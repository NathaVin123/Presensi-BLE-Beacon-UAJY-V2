using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Presensi_BLE_Beacon_UAJY.Common.Models
{
    public class User
    {
        [JsonProperty("npm")]
        public string NPM { get; set; }

        [JsonProperty("kdCalon")]
        public string KD_CALON { get; set; }

        [JsonProperty("idProdi")]
        public string ID_PRODI { get; set; }

        [JsonProperty("idKonsentrasi")]
        public int ID_KONSENTRASI { get; set; }

        [JsonProperty("noMhs")]
        public string NOMHS { get; set; }

        [JsonProperty("namaMhs")]
        public string NAMA_MHS { get; set; }

        [JsonProperty("jnsKel")]
        public string JNS_KEL { get; set; }

        [JsonProperty("tmpLahir")]
        public string TMP_LAHIR { get; set; }

        [JsonProperty("password")]
        public string PASSWORD { get; set; }

        [JsonProperty("kdStatusMhs")]
        public string KD_STATUS_MHS { get; set; }

        [JsonProperty("nppPembimbingAkademik")]
        public string NPP_PEMBIMBING_AKADEMIK { get; set; }

        [JsonProperty("Alamat")]
        public string ALAMAT { get; set; }

        [JsonProperty("password2")]
        public string PASSWORD2 { get; set; }

        [JsonProperty("idProgram")]
        public int ID_PROGRAM { get; set; }

        [JsonProperty("idOrtu")]
        public int ID_ORTU { get; set; }

        [JsonProperty("passwordOrtu")]
        public string PASSWORD_ORTU { get; set; }

        //[JsonProperty("cityId")]
        //public int CityId { get; set; }
    }
}