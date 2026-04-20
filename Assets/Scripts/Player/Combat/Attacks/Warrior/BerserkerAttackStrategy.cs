using DungeonCrawler.Player.Combat.Attacks;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
    public class BerserkerAttackStrategy : AbilityStrategySO
    {
        public override void UseAbility(GameObject caller)
        {
            Debug.Log("Berserker Attack used! Increasing attack speed and damage for a short duration.");
        }
    }
}