using Mechanics.Abstract;

namespace Enemies.Abstract
{
    public abstract class ShootingEnemy : Enemy
    {
        protected abstract IWeapon Weapon { get; }
    }
}