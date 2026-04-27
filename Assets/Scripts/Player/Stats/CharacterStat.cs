using System.Collections.Generic;

namespace DungeonCrawler.Player.Stats
{
    [System.Serializable]
    public class CharacterStat
    {
        public float BaseValue;
        private List<StatModifier> modifiers = new List<StatModifier>();
        public CharacterStat(float baseValue)
        {
            BaseValue = baseValue;
        }

        public float Value
        {
            get
            {
                float finalValue = BaseValue;
                float percentAdd = 0f;

                for (int i = 0; i < modifiers.Count; i++)
                {
                    StatModifier statModifier = modifiers[i];
                    if (statModifier.IsMultiplier)
                    {
                        percentAdd += statModifier.Value;
                    }
                    else
                    {
                        finalValue += statModifier.Value;
                    }
                }
                finalValue *= 1 + percentAdd;
                return finalValue;
            }
        }
        
        public void AddModifier(StatModifier modifier)
        {
            modifiers.Add(modifier);
        }

        public void RemoveModifier(StatModifier modifier)
        {
            modifiers.Remove(modifier);
        }
        
        public List<StatModifier> GetModifiers() => modifiers;
    }
}