using Zenject;

namespace _Project.Core.Runtime.Services
{
    public class SceneLoaderService 
    {
        private ZenjectSceneLoader _sceneLoader;
    
        [Inject]
        private void Construct(ZenjectSceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public void Initialize() {}
        
        public void LoadMenuScene()
        {
            _sceneLoader.LoadScene("1.Menu");
        }

        public void LoadCoreScene()
        {
            _sceneLoader.LoadScene("2.Core");
        }
    }
}
