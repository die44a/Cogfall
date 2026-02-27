using UnityEngine;
using Zenject;

namespace _Project.Core.Runtime.Menu
{
    public class MenuInitializer : IInitializable
    {
        private readonly MenuView _menuView;

        [Inject]
        public MenuInitializer(MenuViewModel menuViewModel, 
            MenuView menuView)
        { 
            _menuView = menuView;
        }
        
        // ReSharper disable Unity.PerformanceAnalysis
        public void Initialize()
        {
            _menuView.Initialize();
            
            Debug.Log("Menu initialized");
        }
    }
}
    