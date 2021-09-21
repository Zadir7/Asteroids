using UnityEngine;
using View;

namespace Utilities.Visitor
{
    public sealed class SpawnableVisitor : ISpawnableVisitor
    {
        public void Visit(AsteroidView spawnable, Transform spawnTransform)
        {
            Object.Instantiate(spawnable, spawnTransform);
        }

        public void Visit(EnemyShipView spawnable, Transform spawnTransform)
        {
            Object.Instantiate(spawnable, spawnTransform);
        }
    }
}