using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks.Ranger
{
    [CreateAssetMenu(menuName = "Combat/Ranger/Focus Shot")]
    public class FocusShotAttackStrategy : AbilityStrategySO
    {
        public override void UseAbility(GameObject caller)
        {
                Debug.Log("Focus Shot used!");
        }
    }
}