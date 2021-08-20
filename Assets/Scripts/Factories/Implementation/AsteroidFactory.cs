using Enemies;
using Enemies.Abstract;
using Factories.Abstract;
using Mechanics.Abstract;

namespace Factories.Implementation
{
    public class AsteroidFactory : EnemyFactory
    {
        public override Enemy CreateEnemy(IMove move, IHealth health)
        {
            return new Asteroid(move, health);
        }
    }
}