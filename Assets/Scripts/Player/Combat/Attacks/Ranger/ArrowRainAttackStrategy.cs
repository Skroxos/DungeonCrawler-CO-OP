using DungeonCrawler.Player.Combat.Attacks;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Ranger
{
    [CreateAssetMenu(menuName = "Combat/Ranger/Arrow Rain")]
    public class ArrowRainAttackStrategy : AbilityStrategySO
    {
        public override void UseAbility(GameObject caller)
        {
            Debug.Log("Arrow Rain used!");
        }
    }
}