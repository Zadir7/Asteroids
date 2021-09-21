using System;
using Mechanics.Abstract;

namespace Mechanics.Implementation
{
    public class PlayerHealth : IHealth
    {
        public event Action<float> OnHit = (float _) => { };
        public float CurrentHealth { get; private set; }
        public float MaximumHealth { get; }

        public PlayerHealth(float maximumHealth)
        {
            MaximumHealth = maximumHealth;
            CurrentHealth = maximumHealth;
        }
        
        public void TakeDamage(float amount)
        {
            OnHit.Invoke(amount);
            if (CurrentHealth < 0)
            {
                //player dies
            }
            else
            {
                CurrentHealth -= amount;
            }
        }
    }
}