using Mechanics.Abstract;

namespace Enemies.Abstract
{
    public abstract class Enemy
    {
        protected abstract IMove Move { get; }
        protected abstract IHealth Health { get; }
    }
}