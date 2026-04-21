using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Ranger
{
    [CreateAssetMenu(menuName = "Combat/Ranger/Enchanted Charged Arrow")]
    public class EnchantedChargedArrowAttackStrategy : AbilityStrategySO
    {
        public override void UseAbility(GameObject caller)
        {
            Debug.Log("Enchanted Charged Arrow used!");
        }
    }
}