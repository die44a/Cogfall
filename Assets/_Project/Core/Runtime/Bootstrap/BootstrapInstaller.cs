using UnityEngine;
using Zenject;

namespace _Project.Core.Runtime.Bootstrap
{
    public class BootstrapInstaller : MonoInstaller
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public override void InstallBindings()
        {
            Debug.Log("Installing Bootstrap Installer");
            
            Container.BindInterfacesAndSelfTo<BootstrapInitializer>().AsSingle().NonLazy();
        }
    }
}
