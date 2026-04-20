using DungeonCrawler.Interfaces.IDamageable;
using UnityEngine;

namespace DungeonCrawler.Components
{
    public class HealthComponent : MonoBehaviour, IDamageable
    {
        [SerializeField] private float health = 100f;

        public void TakeDamage(float damage)
        {
            health -= damage;
            if (health <= 0f)
            {
                Die();
            }
        }

        private void Die()
        {
            Debug.Log($"{gameObject.name} has died.");
            Destroy(gameObject);
        }
    }
}
