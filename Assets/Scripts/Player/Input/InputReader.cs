using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DungeonCrawler.Player.Input
{
    [CreateAssetMenu(fileName = "InputReader", menuName = "InputReader")]
    public class InputReader : ScriptableObject, PlayerInput.IMovementActions, PlayerInput.ICombatActions
    {
        public event Action<Vector3> MoveEvent;
        
        // =========== Combat Events ===============
        public event Action OnAbility1Event;
        public event Action OnAbility2Event;
        public event Action OnAbility3Event;
        public event Action OnAbility4Event;
        
        public event Action OnBasicAttackEvent;
        public event Action OnDashEvent;
        // ==========================================
        
        private PlayerInput _playerInput;

        private void OnEnable()
        {
            if (_playerInput != null) return;
            _playerInput = new PlayerInput();
            _playerInput.Movement.SetCallbacks(this);
            _playerInput.Combat.SetCallbacks(this);
            
            
            _playerInput.Movement.Enable();
            _playerInput.Combat.Enable();
        }

        private void OnDisable()
        {
            _playerInput.Movement.Disable();
            _playerInput.Combat.Disable();
        }
    
       
        public void OnMove(InputAction.CallbackContext context)
        {
           MoveEvent?.Invoke(context.ReadValue<Vector3>());
        }
        

        public void OnDash(InputAction.CallbackContext context)
        {
            if  (context.performed)
            {
                OnDashEvent?.Invoke();
            }
        }

        public void OnBasicAttack(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                OnBasicAttackEvent?.Invoke();
            }

        }

        public void OnAbility_1(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                OnAbility1Event?.Invoke();
            }
        }

        public void OnAbility_2(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                OnAbility2Event?.Invoke();
            }
        }

        public void OnAbility_3(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                OnAbility3Event?.Invoke();
            }
        }

        public void OnAbility_4(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                OnAbility4Event?.Invoke();
            }
        }
    }
}
