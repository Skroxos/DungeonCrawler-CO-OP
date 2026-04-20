using System;
using DungeonCrawler.Enemy.AI;
using DungeonCrawler.Enemy.AI.States;
using UnityEngine;

namespace DungeonCrawler.Enemy.AI.States
{
    [Serializable]
    public class AttackState : EnemyState
    {
        [SerializeField] private float _attackRange = 2f;
        public override EnemyStateType StateType => EnemyStateType.Attack;
        public override void OnEnter(EnemyBrain brain)
        {
            Debug.Log("Entering Attack State");
        }

        public override void OnUpdate(EnemyBrain brain)
        {
           Debug.Log("Attacking...");
        }

        public override void OnExit(EnemyBrain brain)
        {
            Debug.Log("Exiting...");
        }
    }
}