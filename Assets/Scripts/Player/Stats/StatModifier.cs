namespace DungeonCrawler.Player.Stats
{
    public class StatModifier
    {
        public float Value;
        public bool IsMultiplier; //True = percentage , false = flat
        public float Duration;
        public float Timer;

        public StatModifier(float value, bool isMultiplier, float duration)
        {
            Value = value;
            IsMultiplier = isMultiplier;
            Duration = duration;
            Timer = 0f;
        }
    }
}