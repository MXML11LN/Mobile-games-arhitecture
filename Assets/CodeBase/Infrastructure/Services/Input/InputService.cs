using UnityEngine;
using Zenject;

namespace CodeBase.Services
{
    public class InputService : IInitializable, IInputService
    {
        private GameInput _gameInput;

        public Vector2 MovementAxis => _gameInput.GamplayInput.Movement.ReadValue<Vector2>();

        public Vector2 LookAxis => _gameInput.GamplayInput.Look.ReadValue<Vector2>();

        public bool IsAttackButtonUp()
        {
            return _gameInput.GamplayInput.Attack.IsPressed();
        }

        public bool IsJumpButtonUp()
        {
            return _gameInput.GamplayInput.Jump.IsPressed();
        }
        
        public void Initialize()
        {
            _gameInput = new GameInput();
            _gameInput.Enable();
        }
    }
}