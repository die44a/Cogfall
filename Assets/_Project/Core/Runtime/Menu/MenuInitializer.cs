using UnityEngine;
using Zenject;

namespace _Project.Core.Runtime.Menu
{
    public class MenuInitializer : IInitializable
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public void Initialize()
        {
            Debug.Log("Initializing Menu");
        }
    }
}
    