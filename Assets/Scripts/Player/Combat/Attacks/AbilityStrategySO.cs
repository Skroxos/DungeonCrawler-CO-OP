using UnityEngine;

namespace DungeonCrawler.Player.Combat.Attacks
{
 public abstract class AbilityStrategySO : ScriptableObject
 {
  [Header("General Data")]
  public string AbilityName;
  public Sprite AbilityIcon;
  public float Cooldown;
  public int Cost;
 
  public abstract void UseAbility(GameObject caller);
 }
}