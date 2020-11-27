using Object = UnityEngine.Object;

namespace Core.CreationPatterns.Factory
{
    public class PowerUpsFactory
    {
        private PowerUpConfiguration _powerUpConfiguration;

        public PowerUpsFactory(PowerUpConfiguration powerUpConfiguration)
        {
            _powerUpConfiguration = powerUpConfiguration;
        }
    
        public PowerUp Create(string id)
        {
            var powerUp = _powerUpConfiguration.GetPowerUpPrefabById(id);
            return Object.Instantiate(powerUp);
        }
    }
}