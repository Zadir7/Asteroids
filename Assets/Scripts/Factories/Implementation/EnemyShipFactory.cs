using Enemies;
using Enemies.Abstract;
using Factories.Abstract;
using Mechanics.Abstract;
using Mechanics.Implementation;

namespace Factories.Implementation
{
    public class EnemyShipFactory : EnemyFactory
    {
        public override Enemy CreateEnemy(IMove move, IHealth health)
        {
            var weapon = new EnemyShipWeapon();
            return new EnemyShip(move, health, weapon);
        }
    }
}