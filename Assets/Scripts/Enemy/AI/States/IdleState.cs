using UnityEngine;

namespace DungeonCrawler.Enemy.AI.States
{
    public class IdleState : IState
    {
        public void Enter(IState state)
        {
            Debug.Log("Entering Idle State");
        }

        public void Tick(IState state)
        {
            Debug.Log("Idling...");
        }

        public void Exit(IState state)
        {
            Debug.Log("Exiting Idle State");
        }
    }
}