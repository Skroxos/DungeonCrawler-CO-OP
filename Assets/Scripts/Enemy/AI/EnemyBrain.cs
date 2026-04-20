using System;
using System.Collections.Generic;
using UnityEngine;
using DungeonCrawler.Enemy.AI.States;
using Unity.Netcode;
using UnityEngine.AI;

namespace DungeonCrawler.Enemy.AI
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class EnemyBrain : NetworkBehaviour
    {
        [Header("Data")]
        public Transform target;
        public NavMeshAgent agent;
        
        
        [Header("State Machine")]
        [SerializeReference, SubclassSelector] 
        [SerializeField]
        private List<EnemyState> availableStates = new  List<EnemyState>();
        
        public NetworkVariable<EnemyStateType> CurrentNetState = new NetworkVariable<EnemyStateType>(
            EnemyStateType.Idle,
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Server
            );
        
        
        private EnemyState _currentState;
        private Dictionary<EnemyStateType, EnemyState> _stateDictionary;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            InitializeStates();
        }

        public override void OnNetworkSpawn()
        {
            if (!IsServer)
            {
                agent.enabled = false;
                return;
            }
            SwitchState(EnemyStateType.Idle);
        }

        private void Update()
        {
            if (!IsServer || _currentState == null) return;
            _currentState?.OnUpdate(this);
        }

        private void InitializeStates()
        {
            _stateDictionary = new Dictionary<EnemyStateType, EnemyState>();
            foreach (var state in availableStates)
            {
                _stateDictionary[state.StateType] = state;
            }
        }

        public void SwitchState(EnemyStateType newStateType)
        {
            if (!IsServer)  return;
            if (_stateDictionary.TryGetValue(newStateType, out var state))
            {
                _currentState?.OnExit(this);
                _currentState = state;
                _currentState.OnEnter(this);
                
                CurrentNetState.Value = newStateType;
            }
        }
    }
}
