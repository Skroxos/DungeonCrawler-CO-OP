using DungeonCrawler.Player.Combat.Attacks;
using DungeonCrawler.Player.Context;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DungeonCrawler.Player.Combat.Attacks
{
 public abstract class AbilityStrategySO : ScriptableObject
 {
  [Header("General Data")]
  public string AbilityName;
  public Sprite AbilityIcon;
  public float Cooldown;
  public int Cost;
 
  public abstract void UseAbility(PlayerContext caller);
 }
}