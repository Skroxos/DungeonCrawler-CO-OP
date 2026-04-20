using UnityEngine;

namespace DungeonCrawler.Enemy.AI.States
{
    public class WanderingState : IState
    {
        public void Enter(IState state)
        {
            Debug.Log("Entering Wandering State");
        }

        public void Tick(IState state)
        {
            Debug.Log("Wandering...");
        }

        public void Exit(IState state)
        {
            Debug.Log("Exiting Wandering State");
        }
    }
}