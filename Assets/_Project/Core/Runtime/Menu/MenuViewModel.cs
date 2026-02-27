using Zenject;

namespace _Project.Core.Runtime.Menu
{
    public class MenuViewModel
    {
        private MenuModel _menuModel;
        private MenuView _menuView;

        [Inject]
        private void Construct(MenuModel menuModel, MenuView menuView)
        {
            _menuModel = menuModel;
            _menuView = menuView;
        }
    }
}
