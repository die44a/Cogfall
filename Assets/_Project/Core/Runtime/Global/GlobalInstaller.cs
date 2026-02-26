using _Project.Core.Runtime.Services;
using Zenject;

namespace _Project.Core.Runtime.Global
{
    public class GlobalInstaller : MonoInstaller
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public override void InstallBindings()
        {
            Container.Bind<SceneLoaderService>()
                .AsSingle();
        }
    }
}
