using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Presensi_BLE_Beacon_UAJY.Common.ViewModels;

namespace Presensi_BLE_Beacon_UAJY
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();


            this.RegisterAppStart<LoginViewModel>();
        }
    }                       
}
