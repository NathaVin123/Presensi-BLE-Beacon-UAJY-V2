using System;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Presensi_BLE_Beacon_UAJY.Helpers
{
    public static class Settings
    {
        private static ISettings AppSettings => CrossSettings.Current;

        public static string NPM
        {
            get => AppSettings.GetValueOrDefault(nameof(NPM), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(NPM), value);
        }

        public static string PASSWORD
        {
            get => AppSettings.GetValueOrDefault(nameof(PASSWORD), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(PASSWORD), value);
        }

        public static string AccessToken
        {
            get => AppSettings.GetValueOrDefault(nameof(AccessToken), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(AccessToken), value);
        }

        public static DateTime AccessTokenExpirationDate
        {
            get => AppSettings.GetValueOrDefault(nameof(AccessTokenExpirationDate), DateTime.UtcNow);
            set => AppSettings.AddOrUpdateValue(nameof(AccessTokenExpirationDate), value);
        }
    }
}