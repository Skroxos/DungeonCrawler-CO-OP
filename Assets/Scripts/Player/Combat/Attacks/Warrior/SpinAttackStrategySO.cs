using Cysharp.Threading.Tasks;
using DungeonCrawler.Player.Context;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
    [CreateAssetMenu(menuName="Combat/Warrior/SpinAttackStrategy")]
    public class SpinAttackStrategySO : AbilityStrategySO
    {
        [Header("Spin Attack Data")]
        public float BaseDamage;
        public float AreaRadius;
        public float SpinDuration;
        public float Interval;
        public override void UseAbility(PlayerContext caller)
        {
            var token = caller.PlayerGameObject.GetCancellationTokenOnDestroy();
            OverTimeAttackLogic.OverTimeAttackAsync(token, SpinDuration, BaseDamage, Interval, AreaRadius, caller.PlayerGameObject).Forget();
        }
    }
}