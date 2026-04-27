using DungeonCrawler.Player.Context;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Ranger
{
    [CreateAssetMenu(menuName = "Combat/Ranger/Arrow Rain")]
    public class ArrowRainAttackStrategy : AbilityStrategySO
    {
        public override void UseAbility(PlayerContext caller)
        {
            Debug.Log("Arrow Rain used!");
        }
    }
}