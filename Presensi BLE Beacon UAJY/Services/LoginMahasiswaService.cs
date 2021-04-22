using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Presensi_BLE_Beacon_UAJY.Models;
using Presensi_BLE_Beacon_UAJY.Helpers;
using Presensi_BLE_Beacon_UAJY.Interfaces;

namespace Presensi_BLE_Beacon_UAJY.Services
{
    public class LoginMahasiswaService  : ILoginMahasiswaService
    {
        private readonly HttpClient _client;

        public LoginMahasiswaService()
        {
            _client = new HttpClient();
        }

        private StringContent GetStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var content = new StringContent(serialized, Encoding.UTF8, "application/json");
            return content;
        }

        public async Task<LoginMahasiswaResult> LoginMahasiswa(LoginMahasiswaModel loginMahasiswaModel)
        {
            var uri = new Uri(string.Format(Constants.BaseAddress + "/api/auth/loginmhs", string.Empty));
            var response = await _client.PostAsync(uri, GetStringContentFromObject(loginMahasiswaModel));
            var result = JsonConvert.DeserializeObject<LoginMahasiswaResult>(await response.Content.ReadAsStringAsync());

            if (!response.IsSuccessStatusCode)
            {
                return result;
            }

            Settings.AccessToken = result.token;
            return result;
        }
    }
}
