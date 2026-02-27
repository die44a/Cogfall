using UnityEngine;
using Zenject;

namespace _Project.Core.Runtime.Bootstrap
{
    public class BootstrapInstaller : MonoInstaller
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<BootstrapInitializer>().AsSingle().NonLazy();
        }
    }
}
