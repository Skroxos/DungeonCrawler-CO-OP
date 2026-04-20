using DungeonCrawler.Interfaces.IDamageable;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
    [CreateAssetMenu(menuName="Combat/GroundSlamStrategy")]
    public class GroundSlamStrategySO : AbilityStrategySO
    {
        public override void UseAbility(GameObject caller)
        {
            var hitColliders = Physics.OverlapSphere(caller.transform.position, 1f);
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.TryGetComponent(out IDamageable damageable))
                {
                    damageable.TakeDamage(10);
                }
            }
        
        }
    }
}