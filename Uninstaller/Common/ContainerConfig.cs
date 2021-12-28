using Uninstaller.Data;
using Uninstaller.ViewModels;
using Ninject.Modules;
using Uninstaller.Services;

namespace Uninstaller.Common
{
    public class ContainerConfig : NinjectModule
    {
        public override void Load()
        {
            Bind<MainViewModel>().ToSelf();
            Bind<IRegistryService>().To<RegistryService>();
        }
    }
}
