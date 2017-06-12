using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using FileUploader.Core.ViewModels;

namespace FileUploader.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
