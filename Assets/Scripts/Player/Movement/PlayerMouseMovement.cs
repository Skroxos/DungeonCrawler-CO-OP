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
        

        private void MoveToPosition()
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                _agent.SetDestination(hit.point);
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position.WithY(1), 2.5f);
        }
    }
}
