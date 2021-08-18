using UnityEngine;

namespace Mechanics.Abstract
{
    public interface IWeapon
    {
        public Rigidbody2D Bullet { get; }

        public void Shoot();
    }
}