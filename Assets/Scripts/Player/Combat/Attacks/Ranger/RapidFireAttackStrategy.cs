using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Ranger
{
    public class RapidFireAttackStrategy : AbilityStrategySO
    {
        public override void UseAbility(GameObject caller)
        {
            Debug.Log("Rapid Fire used!");
        }
    }
}