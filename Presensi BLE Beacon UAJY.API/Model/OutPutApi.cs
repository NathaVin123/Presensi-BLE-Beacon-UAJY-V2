using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presensi_BLE_Beacon_UAJY.API.Model
{
    public class OutPutApi
    {
        public bool status { get; set; }
        public string pesan { get; set; }
        public dynamic data { get; set; }
    }
}