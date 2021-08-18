using Mechanics.Abstract;
using UnityEngine;

namespace Mechanics.Implementation
{
    public class PlayerBasicWeapon : IWeapon
    {
        public Rigidbody2D Bullet { get; }

        private const float BulletStartingForce = 10.0f;

        public PlayerBasicWeapon(Rigidbody2D bullet)
        {
            Bullet = bullet;
        }
        
        public void Shoot()
        {
            var bullet = Object.Instantiate(Bullet);
            //TODO: Get normal vector for bullet to fly at
            bullet.AddForce(Vector2.up * BulletStartingForce);
        }
    }
}