using Enemies.Abstract;

namespace Mechanics.Abstract
{
    public interface IEnemyPrototyper
    {
        Enemy Prototype(Enemy enemy);
    }
}