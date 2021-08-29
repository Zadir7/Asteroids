using Enemies.Abstract;
using Mechanics.Abstract;
using Utilities.Extensions;

namespace Mechanics.Implementation
{
    public class EnemyPrototyper : IEnemyPrototyper
    {
        public Enemy Prototype(Enemy enemy)
        {
            return enemy.DeepCopy();
        }
    }
}