using UnityEngine;

namespace DungeonCrawler.Enemy.AI.States
{
    public class AttackState : IState
    {
        public void Enter(IState state)
        {
            Debug.Log("Entering Attack State");
        }

        public void Tick(IState state)
        {
            Debug.Log("Attacking...");
        }

        public void Exit(IState state)
        {
            Debug.Log("Exiting Attack State");
        }
    }
}