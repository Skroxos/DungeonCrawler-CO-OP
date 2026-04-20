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
            Debug.Log("Skull Crusher used! Dealing " + BaseDamage + " damage to the target.");
        }
    }
}