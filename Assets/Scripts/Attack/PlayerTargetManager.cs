using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;

namespace DungeonCrawler.Attack
{
    public class PlayerTargetManager : MonoBehaviour
    {
      //  public event Action OnTargetChangeEvent;
        public GameObject CurrentTarget { get; private set; }
        
        public void SetTarget(GameObject target)
        {
            CurrentTarget = target;
         //   OnTargetChangeEvent?.Invoke();
        }

        public Vector3 GetTargetPosition()
        {
            return CurrentTarget.transform.position;
        }
        
        public void  ClearTarget()
        {
            CurrentTarget = null;
        }
    }
} 