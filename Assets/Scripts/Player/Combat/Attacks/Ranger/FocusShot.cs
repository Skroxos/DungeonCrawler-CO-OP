using DungeonCrawler.Player.Context;
using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Ranger
{
    [CreateAssetMenu(menuName = "Combat/Ranger/Focus Shot")]
    public class FocusShotAttackStrategy : AbilityStrategySO
    {
        [SerializeField] private float baseDamage;
        [SerializeField] private int castTime;
        public override void UseAbility(PlayerContext caller)
        { 
            Debug.Log("Focus Shot used!");
        }
        
    }
}


    
