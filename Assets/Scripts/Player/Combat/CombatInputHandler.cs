using System.Collections.Generic;
using DungeonCrawler.Player.Combat.Attacks;
using DungeonCrawler.Player.Input;
using UnityEngine;

namespace DungeonCrawler.Player.Combat
{
    public class CombatInputHandler : MonoBehaviour
    {
        [SerializeField]
        private InputReader _inputReader;
        [SerializeField]
        private AbilityController _abilityController;

        private void Awake()
        {
            // _inputReader = Resources.Load<InputReader>("Assets/Scripts/Player/Input/So/InputReader.asset");
        }

        private void OnEnable()
        {
            _inputReader.OnBasicAttackEvent += HandleBasicAttack;
            _inputReader.OnAbility1Event += HandleAbility1;
            _inputReader.OnAbility2Event += HandleAbility2;
            _inputReader.OnAbility3Event += HandleAbility3;
            _inputReader.OnAbility4Event += HandleAbility4;
            _inputReader.OnDashEvent += HandleDash;
        }

        private void OnDisable()
        {
            _inputReader.OnBasicAttackEvent -= HandleBasicAttack;
            _inputReader.OnAbility1Event -= HandleAbility1;
            _inputReader.OnAbility2Event -= HandleAbility2;
            _inputReader.OnAbility3Event -= HandleAbility3;
            _inputReader.OnAbility4Event -= HandleAbility4;
            _inputReader.OnDashEvent -= HandleDash;
        }

        private void HandleBasicAttack()
        {
            Debug.Log("Basic Attack Triggered");
        }

        private void HandleAbility1()
        {
            _abilityController.TryCastAbility(0);
        }
    
        private void HandleAbility2()
        {
            Debug.Log("Ability 2 Triggered");
        }
    
        private void HandleAbility3()
        {
            Debug.Log("Ability 3 Triggered");
        }
    
        private void HandleAbility4()
        {
            Debug.Log("Ability 4 Triggered");
        }

        private void HandleDash()
        {
            Debug.Log("Dash Triggered");
        }
    }
}
