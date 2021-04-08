namespace Presensi_BLE_Beacon_UAJY.Common.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IDialogService
    {
        void Alert(string message, string title, string okbtnText);
    }
}
