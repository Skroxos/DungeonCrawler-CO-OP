using System.Threading;
using Cysharp.Threading.Tasks;
using DungeonCrawler.Interfaces.IDamagable;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
    public static class OverTimeAttackLogic
    {
        public static async UniTask OverTimeAttackAsync(CancellationToken ct, float duration, float dmg, float interval,float radius , GameObject caller)
        {
            float elapsedTime = 0f;
            while (elapsedTime < duration)
            {
                ApplyDmg(dmg, radius, caller);
                await UniTask.Delay(System.TimeSpan.FromSeconds(interval), cancellationToken: ct);
                elapsedTime += interval;
            }
            Debug.Log("Spin attack completed.");
        }

        private static void ApplyDmg(float dmg,float radius, GameObject caller)
        {
            var hitColliders = Physics.OverlapSphere(caller.transform.position, radius);
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.TryGetComponent(out IDamageable damageable))
                {
                    damageable.TakeDamage(dmg);
                }
            }
        }
    }
}