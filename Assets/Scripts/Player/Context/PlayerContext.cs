using DungeonCrawler.Player.Stats;
using UnityEngine;

namespace DungeonCrawler.Player.Context
{
    public class PlayerContext
    {
        public readonly GameObject PlayerGameObject;
        public readonly PlayerStatsManager StatsManager;
        
        public PlayerContext(GameObject playerGameObject)
        {
            PlayerGameObject = playerGameObject;
            StatsManager = playerGameObject.GetComponent<PlayerStatsManager>();
        }
    }
}
