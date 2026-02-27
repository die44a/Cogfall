using System;
using UnityEngine;
using Zenject;

namespace _Project.Core.Runtime.Menu
{
    public class MenuViewModel
    {
        private MenuModel _menuModel;
        private MenuView _menuView;
        private MenuService _menuService;

        [Inject]
        private void Construct(MenuModel menuModel, 
            MenuView menuView, 
            MenuService menuService)
        {
            _menuModel = menuModel;
            _menuView = menuView;
            _menuService = menuService;
        }
        
        public void HandleStartButtonClick()
        {
            Debug.Log("Start button click");
            _menuService.OnStartButtonClicked();
        }

        public void HandleExitButtonClick()
        {
            _menuService.OnExitButtonClicked();
            Debug.Log("Exit button click");
        }
    }
}
