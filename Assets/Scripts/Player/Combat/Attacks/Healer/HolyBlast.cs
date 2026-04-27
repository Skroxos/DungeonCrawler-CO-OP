using DungeonCrawler.Player.Context;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Healer
{
    [CreateAssetMenu(menuName = "Combat/Healer/HolyBlast")]
    public class HolyBlast : AbilityStrategySO
    {
        public override void UseAbility(PlayerContext caller)
        {}
    }
}