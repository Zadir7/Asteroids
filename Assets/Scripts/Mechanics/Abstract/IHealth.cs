using System;

namespace Mechanics.Abstract
{
    public interface IHealth
    {
        public event Action<float> OnHit;
        public float CurrentHealth { get; }
        public float MaximumHealth { get; }

        public void TakeDamage(float amount);
    }
}