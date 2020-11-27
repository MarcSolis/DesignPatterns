using UnityEngine;

namespace Core.CreationPatterns.Factory
{
    public abstract class PowerUp : MonoBehaviour
    {
        [SerializeField] private string _id;

        public string ID => _id;
    }
}