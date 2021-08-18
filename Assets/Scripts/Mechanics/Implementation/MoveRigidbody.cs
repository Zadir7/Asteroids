using Mechanics.Abstract;
using UnityEngine;

namespace Mechanics.Implementation
{
    public class MoveRigidbody : IMove
    {
        private readonly Rigidbody2D _rigidbody;
        public float Speed { get; }

        public MoveRigidbody(Rigidbody2D rigidbody, float speed)
        {
            _rigidbody = rigidbody;
            Speed = speed;
        }
        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var deltaSpeed = deltaTime * Speed;
            _rigidbody.AddForce(new Vector2(horizontal, vertical) * deltaSpeed, ForceMode2D.Impulse);
        }
    }
}