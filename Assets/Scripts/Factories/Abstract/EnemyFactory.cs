using Enemies;
using Enemies.Abstract;
using Mechanics.Abstract;

namespace Factories.Abstract
{
    public abstract class EnemyFactory
    {
        public abstract Enemy CreateEnemy(IMove move, IHealth health);
    }
}