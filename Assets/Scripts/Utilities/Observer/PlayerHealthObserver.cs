using System;
using Mechanics.Abstract;

namespace Utilities.Observer
{
    public sealed class PlayerHealthObserver : IDisposable
    {
        private readonly IHealth _playerHealth;
        private readonly HealthOnHitEventListener _listener;
        
        public PlayerHealthObserver(IHealth playerHealth)
        {
            _playerHealth = playerHealth;
            _listener = new HealthOnHitEventListener();
            _listener.Add(_playerHealth);
        }

        private void ReleaseUnmanagedResources()
        {
            _listener.Remove(_playerHealth);
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }
    }
}