using System;
using System.Collections.Generic;
using UnityEngine;
using DungeonCrawler.Enemy.AI.States;
using Unity.Netcode;

namespace DungeonCrawler.Enemy.AI
{
    public class EnemyBrain : NetworkBehaviour
    {
        [Header("State Machine")]
        [SerializeReference, SubclassSelector] 
        [SerializeField]
        private List<EnemyState> availableStates = new  List<EnemyState>();
        
        private EnemyState _currentState;
        private Dictionary<EnemyStateType, EnemyState> _stateDictionary;

        private void Awake()
        {
            InitializeStates();
        }

        private void InitializeStates()
        {
            _stateDictionary = new Dictionary<EnemyStateType, EnemyState>();
            foreach (var state in availableStates)
            {
                _stateDictionary[state.StateType] = state;
            }
        }
    }
}
