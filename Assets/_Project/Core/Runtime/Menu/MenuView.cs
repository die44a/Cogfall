using _Project.Core.Runtime.Services;
using UnityEngine;
using Zenject;

namespace _Project.Core.Runtime.Menu
{
    public class MenuView : MonoBehaviour
    {
        private MenuViewModel _menuViewModel;
        
        [Inject]
        private void Construct(MenuViewModel menuViewModel)
        {
            _menuViewModel = menuViewModel;
        }

        public void OnStart()
        {
            Debug.Log("Game Started");
        }

        public void OnQuit()
        {
            Debug.Log("Game Quit");
        }
    }
}
