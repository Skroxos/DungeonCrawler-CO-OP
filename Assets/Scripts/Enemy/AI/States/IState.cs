namespace  DungeonCrawler.Enemy.AI.States
{
    public interface IState
    {
        public void Enter(IState state);
        public void Tick(IState state);
        public void Exit(IState state);
    }
}