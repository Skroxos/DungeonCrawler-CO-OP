using System;
using DungeonCrawler.Attack;
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
        PlayerTargetManager _targetManager;


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
            _targetManager = GetComponent<PlayerTargetManager>();
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
           
        }
        

        private void MoveToPosition()
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.CompareTag("Enemy"))
                {
                    _targetManager.SetTarget(hit.collider.gameObject);
                    _agent.SetDestination(hit.point);
                }
                else
                {
                    _targetManager.ClearTarget();
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
