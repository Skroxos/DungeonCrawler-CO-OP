using DungeonCrawler.Player.Combat.Attacks;
using DungeonCrawler.Player.Context;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Healer
{
    [CreateAssetMenu(menuName = "Combat/Healer/HolySpear")]
    public class HolySpear : AbilityStrategySO
    {
        public override void UseAbility(PlayerContext caller)
        {}
    }
}