using DungeonCrawler.Player.Context;
using DungeonCrawler.Player.Stats;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
    [CreateAssetMenu(menuName = "Combat/Warrior/Berserker Attack")]
    public class BerserkerAttackStrategy : AbilityStrategySO
    {
        [Header("Berserker Attack Data")]
        [SerializeField] private float damageBuffValue;
        [SerializeField] private float attackSpeedBuffValue;

        [SerializeField] private float duration;
        
        public override void UseAbility(PlayerContext caller)
        {
            if (caller.StatsManager == null)
            {
                Debug.LogError("PlayerStatsManager component not found on caller.");
                return;
            }
            caller.StatsManager.ApplyModifiers(caller.StatsManager.Damage, damageBuffValue, duration, false);
            caller.StatsManager.ApplyModifiers(caller.StatsManager.AttackSpeed, attackSpeedBuffValue, duration, true);
            
        }
    }
}