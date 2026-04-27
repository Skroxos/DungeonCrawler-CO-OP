using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Warrior
{
[CreateAssetMenu(menuName="Combat/Warrior/SkullCrusherStrategy")]
    public class SkullCrusherAttackStrategySo : AbilityStrategySO
    {
        [Header("Skull Crusher Data")]
        public float BaseDamage;
    
        public override void UseAbility(GameObject caller)
        {
            // need to make an enemy target system to get the target and apply damage to it, for now just log the attack
            Debug.Log("Skull Crusher used! Dealing " + BaseDamage + " damage to the target.");
        }
    }
}