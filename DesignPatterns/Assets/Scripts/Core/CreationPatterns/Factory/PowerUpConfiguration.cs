using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core.CreationPatterns.Factory
{
    [CreateAssetMenu(menuName = "ScriptableObject/PowerUp Configuration")]
    public class PowerUpConfiguration : ScriptableObject
    {
        [SerializeField] private PowerUp[] _powerUps;
        private Dictionary<string, PowerUp> _powerUpToId;

        public void Initialize()
        {
            _powerUpToId = new Dictionary<string, PowerUp>();
            foreach (var powerUp in _powerUps)
            {
                _powerUpToId.Add(powerUp.ID, powerUp);
            }
        }
        
        public PowerUp GetPowerUpPrefabById(string id)
        {
            if (!_powerUpToId.TryGetValue(id, out var powerUpPrefab))
            {
                throw new Exception($"Power up with id {id} does not exist");
            }
            return powerUpPrefab;
        }
    }
}