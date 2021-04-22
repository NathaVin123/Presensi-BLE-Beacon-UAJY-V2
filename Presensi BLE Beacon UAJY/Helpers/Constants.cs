using System;
using System.Collections.Generic;
using System.Text;

namespace Presensi_BLE_Beacon_UAJY.Helpers
{
    public static class Constants
    { 
        public static string BaseAddress = "https://192.168.100.2:5001";
        public static string LoginMahasiswaAddress = "/api/auth/loginmhs/";
        public static string LoginMahasiswaUrl = BaseAddress + LoginMahasiswaAddress;
    }
}