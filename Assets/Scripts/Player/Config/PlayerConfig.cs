using UnityEngine;

namespace DungeonCrawler.Player.Config
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "PlayerConfig")]
    public class PlayerConfig : ScriptableObject
    {
        public float MoveSpeed;
        public float RotationSpeed;

    }
}
