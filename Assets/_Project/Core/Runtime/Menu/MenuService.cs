using System;
using _Project.Core.Runtime.Services;
using UnityEngine;
using Zenject;

namespace _Project.Core.Runtime.Menu
{
    public class MenuService
    {
        private SceneLoaderService _sceneLoaderService;
        private MenuViewModel _menuViewModel;

        [Inject]
        public MenuService(SceneLoaderService sceneLoaderService,
            MenuViewModel menuViewModel)
        {
            _sceneLoaderService = sceneLoaderService;
            _menuViewModel = menuViewModel;
        }
        
        public void OnStartButtonClicked()
        {
            _sceneLoaderService.LoadCoreScene();
        }

        public void OnExitButtonClicked()
            => Application.Quit();
        
    }
}
