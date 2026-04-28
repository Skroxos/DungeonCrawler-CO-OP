using DungeonCrawler.Attack;
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
        public readonly PlayerTargetManager TargetManager;
        
        public PlayerContext(GameObject playerGameObject)
        {
            PlayerGameObject = playerGameObject;
            TargetManager = playerGameObject.GetComponent<PlayerTargetManager>();
            StatsManager = playerGameObject.GetComponent<PlayerStatsManager>();
            NavMeshAgent = playerGameObject.GetComponent<NavMeshAgent>();
        }
    }
}
