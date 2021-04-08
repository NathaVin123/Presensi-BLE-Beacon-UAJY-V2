namespace Presensi_BLE_Beacon_UAJY.API.ViewModels
{
    using Microsoft.AspNetCore.Http;
    using Presensi_BLE_Beacon_UAJY.API.Data.Entities;
    using System.ComponentModel.DataAnnotations;

    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
