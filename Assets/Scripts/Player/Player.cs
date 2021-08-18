using Mechanics.Abstract;

namespace Player
{
    internal sealed class Player
    {
        private readonly IMove _move;
        private readonly IInput _input;
        private readonly IHealth _health;

        internal Player(IMove move, IInput input, IHealth health)
        {
            _move = move;
            _input = input;
            _health = health;
        }

        internal void Move(float deltaTime)
        {
            _move.Move(_input.Horizontal, _input.Vertical, deltaTime);
        }

        internal void TakeDamage(float amount)
        {
            _health.TakeDamage(amount);
        }
    }
}