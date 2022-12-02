using CodeBase.Services;
using Zenject;

namespace CodeBase.Infrastructure
{
    public class BootstrapInstaller : MonoInstaller, IInitializable
    {
        public override void InstallBindings()
        {
            Container.Bind<IInputService>().To<InputService>().AsSingle();

        }
        public void Initialize()
        {
        }
    }
}
