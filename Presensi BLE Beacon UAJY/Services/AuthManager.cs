using Presensi_BLE_Beacon_UAJY.Interfaces;
using Presensi_BLE_Beacon_UAJY.Models;
using System.Threading.Tasks;

namespace Presensi_BLE_Beacon_UAJY.Services
{
    public class AuthManager
    {
        private readonly ILoginMahasiswaService loginMahasiswaService;

        public AuthManager(ILoginMahasiswaService service)
        {
            loginMahasiswaService = service;
        }

        public Task<LoginMahasiswaResult> LoginAsync(LoginMahasiswaModel loginMahasiswaModel)
        {
            return loginMahasiswaService.LoginMahasiswa(loginMahasiswaModel);
        }
    }
}
