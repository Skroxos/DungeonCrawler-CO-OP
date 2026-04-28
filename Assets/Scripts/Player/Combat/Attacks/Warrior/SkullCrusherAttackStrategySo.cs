using DungeonCrawler.Interfaces.IDamagable;
using DungeonCrawler.Player.Context;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
[CreateAssetMenu(menuName="Combat/Warrior/SkullCrusherStrategy")]
    public class SkullCrusherAttackStrategySo : AbilityStrategySO
    {
        [Header("Skull Crusher Data")]
        public float BaseDamage;
    
        public override void UseAbility(PlayerContext caller)
        {
            // GetCurrentTarget (z PlayerContextu) GetComponent Idamagable ... takeDamage .... EZ Clap
            var target = caller.TargetManager.CurrentTarget;
            
            if (target == null)            
            {
                Debug.LogError("No target selected for Skull Crusher!");
                return;
            }
            
            target.TryGetComponent(out IDamageable damagable);
            if (damagable != null)
            {
                damagable.TakeDamage(BaseDamage + caller.StatsManager.Damage.GetValue());
                Debug.Log($"Skull Crusher hit {target.name} for {BaseDamage} damage!");
            }

        }
    }
}