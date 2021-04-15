namespace Presensi_BLE_Beacon_UAJY.Common.Helpers
{
    using Plugin.Settings;
    using Plugin.Settings.Abstractions;

    public class Settings
    {
        #region Atributtes

        private const string token = "token";
        private const string userNPM = "userNPM";
        private const string userPassword = "userPassword";
        private const string mahasiswa = "mahasiswa";
        private static readonly string stringDefault = string.Empty;

        #endregion Atributtes

        #region Properties

        public static ISettings AppSettings => CrossSettings.Current;

        public static string User
        {
            get => AppSettings.GetValueOrDefault(mahasiswa, stringDefault);
            set => AppSettings.AddOrUpdateValue(mahasiswa, value);
        }

        public static string Token
        {
            get => AppSettings.GetValueOrDefault(token, stringDefault);
            set => AppSettings.AddOrUpdateValue(token, value);
        }

        public static string UserEmail
        {
            get => AppSettings.GetValueOrDefault(userNPM, stringDefault);
            set => AppSettings.AddOrUpdateValue(userNPM, value);
        }

        public static string UserPassword
        {
            get => AppSettings.GetValueOrDefault(userPassword, stringDefault);
            set => AppSettings.AddOrUpdateValue(userPassword, value);
        }

        #endregion Properties
    }
}