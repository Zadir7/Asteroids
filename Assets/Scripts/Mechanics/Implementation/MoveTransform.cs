using Mechanics.Abstract;
using UnityEngine;

namespace Mechanics.Implementation
{
    public class MoveTransform : IMove
    {
        public float Speed { get; private set; }
        
        private readonly Transform _transform;
        private Vector3 _moveDirection;

        public MoveTransform(Transform transform, float speed)
        {
            _transform = transform;
            Speed = speed;
        }
        
        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var deltaSpeed = deltaTime * Speed;
            _moveDirection.Set(horizontal * deltaSpeed, vertical * deltaSpeed, 0.0f);
            _transform.localPosition += _moveDirection;
        }
    }
}