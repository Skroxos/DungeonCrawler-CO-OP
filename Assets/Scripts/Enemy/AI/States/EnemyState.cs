using System;

namespace DungeonCrawler.Enemy.AI.States
{
    public enum EnemyStateType {Idle, Chase, Attack, Dead}

    [Serializable]
    public abstract class EnemyState
    {
        public abstract EnemyStateType StateType { get; }
        public virtual void OnEnter(EnemyBrain brain){}
        public virtual void OnExit(EnemyBrain brain){}
        public virtual void OnUpdate(EnemyBrain brain){}
    }
}