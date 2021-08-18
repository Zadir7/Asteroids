namespace Mechanics.Abstract
{
    public interface IHealth
    {
        public float CurrentHealth { get; }
        public float MaximumHealth { get; }

        public void TakeDamage(float amount);
    }
}