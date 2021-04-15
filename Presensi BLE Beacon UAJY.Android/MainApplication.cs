using System;
using Android.App;
using Android.Runtime;
using Shiny;

namespace Presensi_BLE_Beacon_UAJY.Droid
{
    public partial class MainApplication : Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            //this.ShinyOnCreate(new SampleStartup());
        }
    }
}