using System;
using DungeonCrawler.Player.Input;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace DungeonCrawler.Player.Movement
{
    public class PlayerMouseMovement : NetworkBehaviour
    {
        NavMeshAgent _agent;
        [SerializeField] private InputReader _inputReader;
        GameObject _currentTarget;


        public override void OnNetworkSpawn()
        {
            if (!IsOwner)
            {
                enabled = false;
                return;
            }
           
        }

        private void Awake()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        private void OnEnable()
        {
            _inputReader.OnMouseMoveEvent += MoveToPosition;
        }


        private void OnDisable()
        {
            _inputReader.OnMouseMoveEvent -= MoveToPosition;
        }

        private void Update()
        {
            if (_currentTarget != null)
            {
                float distanceToTarget = Vector3.Distance(transform.position, _currentTarget.transform.position);
                if (distanceToTarget <= _agent.stoppingDistance)
                {
                    _agent.isStopped = true;
                }
                else
                {
                    _agent.isStopped = false;
                    _agent.SetDestination(_currentTarget.transform.position);
                }
            }
        }
        

        private void MoveToPosition()
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    _currentTarget = hit.collider.gameObject;
                    _agent.SetDestination(_currentTarget.transform.position);
                }
                else
                {
                    _agent.isStopped = false;
                    _currentTarget = null;
                    _agent.SetDestination(hit.point);
                }
                
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position.WithY(1), 2.5f);
        }
    }
}
