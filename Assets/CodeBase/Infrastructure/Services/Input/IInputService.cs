using UnityEngine;

namespace CodeBase.Services
{
    public interface IInputService
    {
        Vector2 MovementAxis { get; }
        Vector2 LookAxis { get; }
        public bool IsAttackButtonUp();
        public bool IsJumpButtonUp();
    }
}