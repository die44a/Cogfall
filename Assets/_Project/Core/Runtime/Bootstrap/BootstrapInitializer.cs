using _Project.Core.Runtime.Services;
using Zenject;

namespace _Project.Core.Runtime.Bootstrap
{
    public class BootstrapInitializer : IInitializable
    {
        private readonly SceneLoaderService _sceneLoaderService;

        public BootstrapInitializer(SceneLoaderService sceneLoaderService)
        {
            _sceneLoaderService = sceneLoaderService;
        }

        public void Initialize()
        {
            // Init services
            _sceneLoaderService.Initialize();
            
            // Do something else
            _sceneLoaderService.LoadMenuScene();
        }
    }
}