namespace Presensi_BLE_Beacon_UAJY.API.ViewModels
{
    using System.ComponentModel.DataAnnotations;
    public class ResetPasswordViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Token { get; set; }

    }
}
