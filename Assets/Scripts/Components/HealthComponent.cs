using DungeonCrawler.Interfaces.IDamageable;
using Unity.Netcode;
using UnityEngine;

namespace DungeonCrawler.Components
{
    public class HealthComponent : NetworkBehaviour, IDamageable
    {
        [SerializeField] private NetworkVariable<float> currentHealth = new NetworkVariable<float>();

        public void TakeDamage(float damage)
        {
            if (!IsServer)  return;
            currentHealth.Value -= damage;
            if (currentHealth.Value <= 0f)
            {
                Die();
            }
        }

        private void Die()
        {
            Debug.Log($"{gameObject.name} has died.");
            GetComponent<NetworkObject>().Despawn(true);
        }
    }
}
