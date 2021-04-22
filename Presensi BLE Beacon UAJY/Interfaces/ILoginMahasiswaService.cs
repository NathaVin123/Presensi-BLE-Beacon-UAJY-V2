using Presensi_BLE_Beacon_UAJY.Models;
using System.Threading.Tasks;

namespace Presensi_BLE_Beacon_UAJY.Interfaces
{
    public interface ILoginMahasiswaService
    {
        Task<LoginMahasiswaResult> LoginMahasiswa(LoginMahasiswaModel loginMahasiswaModel);
    }
}