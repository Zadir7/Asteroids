using UnityEngine;
using View;

namespace Utilities.Visitor
{
    public interface ISpawnableVisitor
    {
        public void Visit(AsteroidView spawnable, Transform spawnTransform);
        public void Visit(EnemyShipView spawnable, Transform spawnTransform);
    }
}