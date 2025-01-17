﻿using System;
using System.Collections.Generic;
using System.Linq;
using CoreBluetooth;
using Foundation;
using UIKit;

namespace Presensi_BLE_Beacon_UAJY.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        private static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");

            var bluetoothManager = new CBCentralManager();
            if (bluetoothManager.State == CBCentralManagerState.PoweredOff)
            {
                // Does not go directly to bluetooth on every OS version though, but opens the Settings on most
                UIApplication.SharedApplication.OpenUrl(new NSUrl("App-Prefs:root=Bluetooth"));
            }
        }
    }
}