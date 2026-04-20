using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Ranger
{
    public class EnchantedChargedArrowAttackStrategy : AbilityStrategySO
    {
        public override void UseAbility(GameObject caller)
        {
            Debug.Log("Enchanted Charged Arrow used!");
        }
    }
}