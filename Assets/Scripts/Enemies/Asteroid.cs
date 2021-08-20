using Enemies.Abstract;
using Mechanics.Abstract;

namespace Enemies
{
    public class Asteroid : Enemy
    {
        protected override IMove Move { get; }
        protected override IHealth Health { get; }
        
        public Asteroid(IMove move, IHealth health)
        {
            Move = move;
            Health = health;
        }
    }
}