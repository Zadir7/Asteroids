using Mechanics.Abstract;
using Mechanics.Implementation;
using UnityEngine;
using Updates;

namespace Player
{
    internal sealed class PlayerController : IUpdatable
    {
        private readonly IMove _move;
        private readonly IInput _input;
        
        internal PlayerController(Transform transform, float speed)
        {
            _move = new MoveTransform(transform, speed);
            _input = new PlayerInput();
        }

        public void Update(float deltaTime)
        {
            _move.Move(_input.Horizontal, _input.Vertical, deltaTime);
        }
    }
}