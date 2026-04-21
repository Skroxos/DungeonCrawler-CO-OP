using System.Collections.Generic;
using DungeonCrawler.Player.Combat.Attacks;
using Unity.Netcode;
using UnityEngine;

namespace DungeonCrawler.Player.Combat
{
    public class AbilityController : NetworkBehaviour
    {
        [SerializeField] private List<AbilityStrategySO> abilities;
        private Dictionary<int,float> _lastCastTimes = new Dictionary<int,float>();

        [ServerRpc]
        public void TryCastAbilityServerRPC(int abilityIndex)
        {
            if (abilityIndex < 0 || abilityIndex >= abilities.Count) return;
            AbilityStrategySO ability = abilities[abilityIndex];
            if (ability == null) return;

            if (!_lastCastTimes.ContainsKey(abilityIndex))
            {
                _lastCastTimes[abilityIndex] = 0f;
            }

            float readyTime = _lastCastTimes[abilityIndex] + ability.Cooldown;
            if (Time.time < readyTime)
            {
                Debug.Log($"Ability {ability.AbilityName} is on cooldown! Ready in {readyTime - Time.time:F1}s");
                return;
            }
        
            ability.UseAbility(gameObject);
            _lastCastTimes[abilityIndex] = Time.time;
        }
    }
}
