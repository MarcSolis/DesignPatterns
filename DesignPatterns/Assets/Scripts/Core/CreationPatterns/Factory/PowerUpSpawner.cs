using UnityEngine;

namespace Core.CreationPatterns.Factory
{
    public class PowerUpSpawner : MonoBehaviour
    {
        private PowerUpsFactory _powerUpsFactory;
        
        public void GetFactory(PowerUpsFactory powerUpsFactory)
        {
            _powerUpsFactory = powerUpsFactory;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                _powerUpsFactory.Create("Speed");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _powerUpsFactory.Create("ExtraLife");
            }
        }
    }
}