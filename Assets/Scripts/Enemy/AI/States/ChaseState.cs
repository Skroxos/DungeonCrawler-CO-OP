using System;
using UnityEngine;

namespace DungeonCrawler.Enemy.AI.States
{
    [Serializable]
    public class ChaseState : EnemyState
    {   
        [SerializeField] private float _stopDistance;
        [SerializeField] private float _chaseSpeed;
        
        public override EnemyStateType StateType => EnemyStateType.Chase;
        public override void OnEnter(EnemyBrain brain)
        {
            Debug.Log("Entering Chase State");
        }

        public override void OnUpdate(EnemyBrain brain)
        {
            if (brain.target != null)
            {
                brain.agent.SetDestination(brain.target.position);
                if (brain.agent.remainingDistance < _stopDistance)
                {
                    brain.SwitchState(EnemyStateType.Attack);
                }
            }

            Debug.Log("Updating Chase State");
        }

        public override void OnExit(EnemyBrain brain)
        {
           Debug.Log("Exiting Chase State");
        }
    }
}