using System;
using DungeonCrawler.Enemy.AI;
using DungeonCrawler.Enemy.AI.States;

namespace DungeonCrawler.Enemy.AI.States
{
    [Serializable]
    public class ChaseState : EnemyState
    {   
        public override EnemyStateType StateType => EnemyStateType.Chase;
        public override void OnEnter(EnemyBrain brain)
        {
            base.OnEnter(brain);
            Console.WriteLine("Entering Chase State");
        }

        public override void OnUpdate(EnemyBrain brain)
        {
            base.OnUpdate(brain);
            Console.WriteLine("Chasing...");
        }

        public override void OnExit(EnemyBrain brain)
        {
            base.OnExit(brain);
            Console.WriteLine("Exiting Chase State");
        }
    }
}