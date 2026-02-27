using UnityEngine;
using Zenject;

namespace _Project.Core.Runtime.Menu
{
    public class MenuInstaller : MonoInstaller
    {
        [SerializeField] private MenuView menuView;
        
        // ReSharper disable Unity.PerformanceAnalysis
        public override void InstallBindings()
        {
            Container.BindInstance(menuView).AsSingle();
            Container.Bind<MenuModel>().AsSingle();
            Container.Bind<MenuViewModel>().AsSingle();

            Container.Bind<MenuInitializer>().AsSingle();
        }
    }
}
