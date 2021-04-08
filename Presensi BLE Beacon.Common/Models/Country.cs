using Newtonsoft.Json;
using Presensi_BLE_Beacon_UAJY.Common.Models;
using System.Collections.Generic;

namespace Presensi_BLE_Beacon_UAJY.Models
{
    public class Country
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cities")]
        public List<City> Cities { get; set; }

        [JsonProperty("numberCities")]
        public int NumberCities { get; set; }
    }
}
