using Mechanics.Abstract;
using UnityEngine;

namespace Mechanics.Implementation
{
    public class PlayerInput : IInput
    {
        public float Horizontal => Input.GetAxis(InputAxis.Horizontal.ToString());
        public float Vertical => Input.GetAxis(InputAxis.Vertical.ToString());

        private enum InputAxis
        {
            Horizontal,
            Vertical
        }
    }
}