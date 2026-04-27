using Cysharp.Threading.Tasks;
using DungeonCrawler.Player.Combat.Attacks;
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
        public override void UseAbility(GameObject caller)
        {
            var toke = caller.GetCancellationTokenOnDestroy();
            OverTimeAttackLogic.OverTimeAttackAsync(toke, SpinDuration, BaseDamage, Interval, AreaRadius, caller).Forget();
        }
    }
}