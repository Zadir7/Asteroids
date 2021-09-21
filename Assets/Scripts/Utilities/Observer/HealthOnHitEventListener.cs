using Mechanics.Abstract;
using UnityEngine;

namespace Utilities.Observer
{
    public sealed class HealthOnHitEventListener
    {
        public void Add(IHealth health)
        {
            health.OnHit += DamageOnHit;
        }

        public void Remove(IHealth health)
        {
            health.OnHit -= DamageOnHit;
        }

        private void DamageOnHit(float damage)
        {
            Debug.Log(damage);
        }
    }
}