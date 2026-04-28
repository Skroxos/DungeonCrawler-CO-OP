using DungeonCrawler.Player.Input;
using Unity.Netcode;
using UnityEngine;

namespace DungeonCrawler.Player.Combat
{
    public class CombatInputHandler : NetworkBehaviour
    {
        [SerializeField]
        private InputReader _inputReader;
        private AbilityController _abilityController;

        private void Awake()
        {
            // _inputReader = Resources.Load<InputReader>("Assets/Scripts/Player/Input/So/InputReader.asset");
            _abilityController = GetComponent<AbilityController>();
        }

        public override void OnNetworkSpawn()
        {
            if (IsOwner)
            {
                _inputReader.OnAbility1Event += HandleAbility1;
                _inputReader.OnAbility2Event += HandleAbility2;
                _inputReader.OnAbility3Event += HandleAbility3;
                _inputReader.OnAbility4Event += HandleAbility4;
                _inputReader.OnDashEvent += HandleDash;
            }
        }

        public override void OnNetworkDespawn()
        {
            if (IsOwner)
            {
                _inputReader.OnAbility1Event -= HandleAbility1;
                _inputReader.OnAbility2Event -= HandleAbility2;
                _inputReader.OnAbility3Event -= HandleAbility3;
                _inputReader.OnAbility4Event -= HandleAbility4;
                _inputReader.OnDashEvent -= HandleDash;
            }
        }
        
        

        private void HandleAbility1()
        {
            _abilityController.TryCastAbilityServerRpc(0);
        }
    
        private void HandleAbility2()
        {
            _abilityController.TryCastAbilityServerRpc(1);
        }
    
        private void HandleAbility3()
        {
            _abilityController.TryCastAbilityServerRpc(2);
        }
    
        private void HandleAbility4()
        {
            _abilityController.TryCastAbilityServerRpc(3);
        }

        private void HandleDash()
        {
            Debug.Log("Dash Triggered");
        }

        
    }
}



