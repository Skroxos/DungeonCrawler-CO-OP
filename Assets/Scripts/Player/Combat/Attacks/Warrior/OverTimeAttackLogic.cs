using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
    public static class OverTimeAttackLogic
    {
        public static async UniTask OverTimeAttackAsync(CancellationToken ct, float duration, float dmg, float interval)
        {
            float elapsedTime = 0f;
            while (elapsedTime < duration)
            {
                ApplyDmg(dmg);
                await UniTask.Delay(System.TimeSpan.FromSeconds(interval), cancellationToken: ct);
                elapsedTime += interval;
            }
            Debug.Log("Spin attack completed.");
        }

        private static void ApplyDmg(float dmg)
        {
            Debug.Log("Applying dmg: " + dmg);
        }
    }
}