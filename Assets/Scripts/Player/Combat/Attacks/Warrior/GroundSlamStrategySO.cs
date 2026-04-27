using DungeonCrawler.Interfaces.IDamagable;
using DungeonCrawler.Player.Stats;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
    [CreateAssetMenu(menuName="Combat/Warrior/GroundSlamStrategy")]
    public class GroundSlamStrategySO : AbilityStrategySO
    {
        [Header("Ground Slam Data")]
        public float BaseDamage;
        public float AreaRadius;
        public override void UseAbility(GameObject caller)
        {
            var stats = caller.GetComponent<PlayerStatsManager>();
            var hitColliders = Physics.OverlapSphere(caller.transform.position, AreaRadius);
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.TryGetComponent(out IDamageable damageable))
                {
                    damageable.TakeDamage(BaseDamage + stats.Damage.GetValue());
                }
            }
        
        }
    }
}