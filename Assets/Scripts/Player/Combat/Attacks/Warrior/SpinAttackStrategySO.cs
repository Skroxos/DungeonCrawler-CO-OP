using DungeonCrawler.Interfaces.IDamageable;
using DungeonCrawler.Player.Combat.Attacks;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
    [CreateAssetMenu(menuName="Combat/Warrior/SpinAttackStrategy")]
    public class SpinAttackStrategySO : AbilityStrategySO
    {
        [Header("Spin Attack Data")]
        public float BaseDamage;
        public float AreaRadius;
        public override void UseAbility(GameObject caller)
        {
            var hitColliders = Physics.OverlapSphere(caller.transform.position, AreaRadius);
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.TryGetComponent(out IDamageable damageable))
                {
                    damageable.TakeDamage(BaseDamage);
                }
            }
        }
    }
}