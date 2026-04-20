using System;
using UnityEngine;

namespace DungeonCrawler.Enemy.AI.States
{
    [Serializable]
    public class IdleState : EnemyState
    {
        public override EnemyStateType StateType => EnemyStateType.Idle;
        [SerializeField] private float _sightRange = 10;
        public override void OnEnter(EnemyBrain brain)
        {
            Debug.Log("Entering Idle State");
        }

        public override void OnUpdate(EnemyBrain brain)
        {
            Debug.Log("Idling...");
        }

        public override void OnExit(EnemyBrain brain)
        {
            Debug.Log("Exited Idle State");
        }
    }
}