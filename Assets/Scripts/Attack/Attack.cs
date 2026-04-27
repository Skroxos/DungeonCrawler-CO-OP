using System.Collections;
using DungeonCrawler.Interfaces.IDamagable;
using UnityEngine;

namespace DungeonCrawler.Attack
{
    public class Attack : MonoBehaviour
    {
        private float _attackConeAngle;
        [SerializeField] private Transform attackPoint;


        private void OnEnable()
        {
            StartCoroutine(Attacking());    
        }

        private void OnDisable()
        {         
            StopAllCoroutines();
        }

        private void Update()
        {
            Debug.DrawRay(attackPoint.position, transform.forward, Color.red);
        }

        private void HandleAttack()
        {
            RaycastHit hit;
            if (Physics.Raycast(attackPoint.position, transform.forward, out hit, 30f))
            {
                if (hit.transform.gameObject.TryGetComponent(out IDamageable damageable))
                {
                    damageable.TakeDamage(10f); 
                }
            }
        
        }

        private IEnumerator Attacking()
        {
            while (true)
            {
                HandleAttack();
                yield return new WaitForSeconds(2f);
                print("Attacking...");
            }
        }
    }
}
