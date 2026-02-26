using _Project.Core.Runtime.Services;
using Zenject;

namespace _Project.Core.Runtime.Bootstrap
{
    public class BootstrapInitializer : IInitializable
    {
        private SceneLoaderService  _sceneLoaderService;

        public BootstrapInitializer(SceneLoaderService sceneLoaderService)
        {
            _sceneLoaderService = sceneLoaderService;
        }

        public void Initialize()
        {
            _sceneLoaderService.LoadCoreScene();
        }
    }
}