using System;
using DungeonCrawler.Player.Config;
using DungeonCrawler.Player.Input;
using UnityEngine;

namespace DungeonCrawler.Player.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private InputReader inputReader;
        [SerializeField] private PlayerConfig playerConfig;
        [SerializeField] private CharacterController characterController;

        
        private Vector3 _moveDirection;
        private void OnEnable()
        {
            inputReader.MoveEvent += Move;
        }
        private void OnDisable()
        {
            inputReader.MoveEvent -= Move;
        }

        private void Move(Vector3 obj)
        {
            _moveDirection = obj;
        }

        private void Update()
        {
            HandleMovement();
        }

        private void HandleMovement()
        {
            characterController.Move(_moveDirection * playerConfig.MoveSpeed * Time.deltaTime);
        }
    }
}
