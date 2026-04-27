using DungeonCrawler.Interfaces.IDamagable;
using DungeonCrawler.Player.Context;
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
        public override void UseAbility(PlayerContext caller)
        {
            var stats = caller.StatsManager;
            var hitColliders = Physics.OverlapSphere(caller.PlayerGameObject.transform.position.WithY(1) , AreaRadius);
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