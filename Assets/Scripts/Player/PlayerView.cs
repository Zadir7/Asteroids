using System;
using UnityEngine;

namespace Player
{
    public class PlayerView : MonoBehaviour
    {
        public event Action<Collision> OnPlayerCollision = collision => { };

        private void OnCollisionEnter(Collision other)
        {
            OnPlayerCollision.Invoke(other);
        }
    }
}