using System.Collections.Generic;

namespace DungeonCrawler.Player.Stats
{
    public class StatModifier
    {
        public readonly float Value;
        public readonly bool IsMultiplier;
        public readonly float Duration;
        public float Timer;
        
        
        public StatModifier(float value, bool isMultiplier, float duration)
        {
            Value = value;
            IsMultiplier = isMultiplier;
            Duration = duration;
            Timer = 0;
        }
        
    }
}