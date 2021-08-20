using Enemies.Abstract;
using Mechanics.Abstract;

namespace Enemies
{
    public class EnemyShip : ShootingEnemy
    {
        protected override IMove Move { get; }
        protected override IHealth Health { get; }
        protected override IWeapon Weapon { get; }

        public EnemyShip(IMove move, IHealth health, IWeapon weapon)
        {
            Move = move;
            Health = health;
            Weapon = weapon;
        }
    }
}