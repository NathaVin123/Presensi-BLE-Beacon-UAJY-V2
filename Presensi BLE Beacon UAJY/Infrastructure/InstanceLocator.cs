namespace Presensi_BLE_Beacon_UAJY.Infrastructure
{
    using Presensi_BLE_Beacon_UAJY.ViewModel;
    using Presensi_BLE_Beacon_UAJY.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
