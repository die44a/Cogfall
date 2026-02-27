using System;
using _Project.Core.Runtime.Services;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace _Project.Core.Runtime.Menu
{
    public class MenuView : MonoBehaviour, IDisposable
    {
        private MenuViewModel _menuViewModel;
        
        [Inject]
        private void Construct(MenuViewModel menuViewModel)
        {
            _menuViewModel = menuViewModel;
        }
        
        [SerializeField] private Button startButton;
        [SerializeField] private Button quitButton;

        public void Initialize()
        {
            startButton.onClick.AddListener(_menuViewModel.HandleStartButtonClick);
            quitButton.onClick.AddListener(_menuViewModel.HandleExitButtonClick);
        }

        public void Dispose()
        {
            startButton.onClick.RemoveListener(_menuViewModel.HandleStartButtonClick);
            quitButton.onClick.RemoveListener(_menuViewModel.HandleExitButtonClick);
        }
    }
}
