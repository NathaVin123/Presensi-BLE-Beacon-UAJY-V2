using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Presensi_BLE_Beacon_UAJY.Common.Models
{
    public class Dosen
    {
        [JsonProperty("npp")]
        public string NPP { get; set; }

        [JsonProperty("idProdi")]
        public string ID_PRODI { get; set; }

        [JsonProperty("namaUnit")]
        public string NAMA_UNIT { get; set; }

        [JsonProperty("namaDosen")]
        public string NAMA_DOSEN { get; set; }

        [JsonProperty("namaDosenLengkap")]
        public string NAMA_DOSEN_LENGKAP { get; set; }

        [JsonProperty("noKTP")]
        public string NO_KTP { get; set; }

        [JsonProperty("tempatLahir")]
        public string TEMPAT_LAHIR { get; set; }

        [JsonProperty("jnsKel")]
        public string JNS_KEL { get; set; }

        [JsonProperty("nipPNS")]
        public string NIP_PNS { get; set; }

        [JsonProperty("gelarS1")]
        public string GELAR_S1 { get; set; }

        [JsonProperty("gelarS2")]
        public string GELAR_S2 { get; set; }

        [JsonProperty("gelarS3")]
        public string GELAR_S3 { get; set; }

        [JsonProperty("inisial")]
        public string INISIAL { get; set; }

        [JsonProperty("golongan")]
        public string GOLONGAN { get; set; }

        [JsonProperty("jabatanAkademik")]
        public string JABATAN_AKADEMIK { get; set; }

        [JsonProperty("kdStatusDosen")]
        public string KD_STATUS_DOSEN { get; set; }
    }
}