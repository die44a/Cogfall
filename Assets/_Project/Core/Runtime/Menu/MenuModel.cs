using UnityEngine;
using Zenject;

namespace _Project.Core.Runtime.Menu
{
    public class MenuModel
    {
        private MenuViewModel _menuViewModel;

        [Inject]
        private void Construct(MenuViewModel menuViewModel)
        {
            _menuViewModel = menuViewModel;
        }

        private string PlayerName => "Unknown";
    }
}
