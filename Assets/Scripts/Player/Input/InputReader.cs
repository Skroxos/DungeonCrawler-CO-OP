using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DungeonCrawler.Player.Input
{
    [CreateAssetMenu(fileName = "InputReader", menuName = "InputReader")]
    public class InputReader : ScriptableObject, PlayerInput.ICoreActions, PlayerInput.IMovementActions
    {
        public event Action<Vector3> MoveEvent;
        private PlayerInput _playerInput;

        private void OnEnable()
        {
            if (_playerInput != null) return;
            _playerInput = new PlayerInput();
            _playerInput.Core.SetCallbacks(this);
            _playerInput.Movement.SetCallbacks(this);
            
            
            _playerInput.Movement.Enable();
             _playerInput.Core.Enable();
        }

        private void OnDisable()
        {
            _playerInput.Movement.Disable();
            _playerInput.Movement.Disable();
        }
    
        public void OnNewaction(InputAction.CallbackContext context)
        {
        
        }

        public void OnMove(InputAction.CallbackContext context)
        {
           MoveEvent?.Invoke(context.ReadValue<Vector3>());
        }
    }
}
