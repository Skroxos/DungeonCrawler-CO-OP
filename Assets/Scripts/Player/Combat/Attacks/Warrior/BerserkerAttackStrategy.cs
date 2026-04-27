using DungeonCrawler.Player.Stats;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
    [CreateAssetMenu(menuName = "Combat/Warrior/Berserker Attack")]
    public class BerserkerAttackStrategy : AbilityStrategySO
    {
        [Header("Berserker Attack Data")]
        [SerializeField] private float baseDamage;

        [SerializeField] private float duration;
        
        public override void UseAbility(GameObject caller)
        {
            var playerStats = caller.GetComponent<PlayerStatsManager>();
            if (playerStats == null)
            {
                Debug.LogError("PlayerStatsManager component not found on caller.");
                return;
            }
            playerStats.ApplyModifiers(playerStats.Damage, baseDamage, duration, true);
            
        }
    }
}