using System;
using UnityEngine;

namespace DungeonCrawler.Enemy.AI.States
{
    [Serializable]
    public class ChaseState : EnemyState
    {   
        [SerializeField] private float _stopDistance = 5f;
        [SerializeField] private float _chaseSpeed = 3f;
        
        public override EnemyStateType StateType => EnemyStateType.Chase;
        public override void OnEnter(EnemyBrain brain)
        {
            Debug.Log("Entering Chase State");
        }

        public override void OnUpdate(EnemyBrain brain)
        {
            Debug.Log("Updating Chase State");
        }

        public override void OnExit(EnemyBrain brain)
        {
           Debug.Log("Exiting Chase State");
        }
    }
}