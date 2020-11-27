using UnityEngine;

namespace Core.CreationPatterns.Factory
{
    public class FactoryInstaller : MonoBehaviour
    {
        [SerializeField] private PowerUpSpawner _powerUpSpawner;
        [SerializeField] private PowerUpConfiguration _powerUpConfiguration;
        private PowerUpsFactory _powerUpsFactory;

        public void Start()
        {
            _powerUpConfiguration.Initialize();
            var factory = new PowerUpsFactory(_powerUpConfiguration);
            _powerUpSpawner.GetFactory(factory);
        }
    }
}