using System.Collections.Generic;

namespace DungeonCrawler.Player.Stats
{
    [System.Serializable]
    public class CharacterStat
    {
        public float BaseValue;
        private List<StatModifier> _modifiers = new List<StatModifier>();
        
        public CharacterStat(float baseValue)
        {
            BaseValue = baseValue;
        }
        
        public void AddModifier(StatModifier modifier) => _modifiers.Add(modifier);
        public void RemoveModifier(StatModifier modifier) => _modifiers.Remove(modifier);
        
        public float GetValue()
        {
          float finalValue = BaseValue;
          float percentageAdd = 0f;
          for (int i = 0; i < _modifiers.Count; i++)
          {
              StatModifier statModifier = _modifiers[i];
              if (statModifier.IsMultiplier)
              {
                  percentageAdd += statModifier.Value;
              }
              else
              {
                  finalValue += statModifier.Value;
              }
          }
          finalValue *= (1 + percentageAdd);
          return finalValue;
        }
        
        public List<StatModifier> GetModifiers() => _modifiers;
    }
}