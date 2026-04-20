using UnityEngine;

[CreateAssetMenu(menuName="Combat/GroundSlamStrategy")]
public class GroundSlamStrategySO : AbilityStrategySO
{
    public override void UseAbility(GameObject caller)
    {
        Debug.Log("Using Ground Slam!");
    }
}