using Mechanics.Abstract;

namespace Mechanics.Implementation
{
    public class PlayerHealth : IHealth
    {
        public float CurrentHealth { get; private set; }
        public float MaximumHealth { get; }

        public PlayerHealth(float maximumHealth)
        {
            MaximumHealth = maximumHealth;
            CurrentHealth = maximumHealth;
        }
        
        public void TakeDamage(float amount)
        {
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