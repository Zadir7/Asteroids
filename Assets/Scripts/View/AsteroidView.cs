using UnityEngine;
using Utilities.Visitor;

namespace View
{
    public class AsteroidView : MonoBehaviour, ISpawnable
    {
        public void Accept(ISpawnableVisitor visitor)
        {
            visitor.Visit(this, transform);
        }
    }
}