using DungeonCrawler.Player.Combat.Attacks;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Healer
{
    [CreateAssetMenu(menuName = "Combat/Healer/Revive")]
    public class Revive : AbilityStrategySO
    {
        public override void UseAbility(GameObject caller)
        {}
    }
}