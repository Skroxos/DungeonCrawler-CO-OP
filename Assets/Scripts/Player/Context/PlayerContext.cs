using DungeonCrawler.Player.Stats;
using UnityEngine;
using UnityEngine.AI;

namespace DungeonCrawler.Player.Context
{
    public class PlayerContext
    {
        public readonly GameObject PlayerGameObject;
        public readonly PlayerStatsManager StatsManager;
        public readonly NavMeshAgent NavMeshAgent;
        
        public PlayerContext(GameObject playerGameObject)
        {
            PlayerGameObject = playerGameObject;
            StatsManager = playerGameObject.GetComponent<PlayerStatsManager>();
            NavMeshAgent = playerGameObject.GetComponent<NavMeshAgent>();
        }
    }
}
