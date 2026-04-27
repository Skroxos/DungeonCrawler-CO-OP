using System;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

namespace DungeonCrawler.Player.Stats
{
    public class PlayerStatsManager : NetworkBehaviour
    {
        public CharacterStat Health = new CharacterStat(0);
        public CharacterStat Damage = new CharacterStat (0);
        public CharacterStat Speed = new CharacterStat (0);
        public CharacterStat AttackSpeed = new CharacterStat (0);
        public CharacterStat Defense = new CharacterStat (0);

        private List<CharacterStat> _allStats;

        private void Awake()
        {
            _allStats = new List<CharacterStat>{Health, Damage, Speed, AttackSpeed, Defense};
        }

        private void Update()
        {            
            if (!IsOwner) return;
            float dt = Time.deltaTime;

            foreach (CharacterStat stat in _allStats)
            {
                var modifiers = stat.GetModifiers();
                for (int i = modifiers.Count - 1; i >= 0; i--)
                {
                    StatModifier modifier = modifiers[i];
                    modifier.Timer += dt;

                    if (modifier.Timer >= modifier.Duration)
                    {
                        stat.RemoveModifier(modifier);
                        Debug.Log("Modifier expired and removed.");
                    }
                }
            }
            Debug.Log($"Health: {Health.GetValue()}, Damage: {Damage.GetValue()}, Speed: {Speed.GetValue()}, AttackSpeed: {AttackSpeed.GetValue()}, Defense: {Defense.GetValue()}");
        }

        public void ApplyModifiers(CharacterStat statToModify, float value, float duration, bool isMultiplier)
        {
            if(!IsOwner) return;
            var modifier = new StatModifier(value, isMultiplier, duration);
            statToModify.AddModifier(modifier);

        }
    }


}