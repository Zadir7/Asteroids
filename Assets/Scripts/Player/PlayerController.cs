using Mechanics.Abstract;
using Mechanics.Implementation;
using UnityEngine;
using Updates;

namespace Player
{
    internal sealed class PlayerController : IUpdatable, ICleanup
    {
        private const float StartingMaximumHealth = 100.0f; //TODO: depend on difficulty
        private const float DamageTakenOnCollision = 10.0f; //TODO: depend on difficulty, asteroid size, etc

        private readonly Player _player;
        private readonly PlayerView _playerView;
        
        internal PlayerController(Rigidbody2D rigidbody, float speed)
        {
            IMove move = new MoveRigidbody(rigidbody, speed);
            IInput input = new PlayerInput();
            IHealth health = new PlayerHealth(StartingMaximumHealth);

            _player = new Player(move, input, health);
            _playerView.OnPlayerCollision += Collide;
        }

        public void Update(float deltaTime)
        {
            _player.Move(deltaTime);
        }

        private void Collide(Collision objectToCollide)
        {
            //TODO: if objectToCollide is asteroid
            _player.TakeDamage(DamageTakenOnCollision);
        }

        public void Cleanup()
        {
            _playerView.OnPlayerCollision -= Collide;
        }
    }
}