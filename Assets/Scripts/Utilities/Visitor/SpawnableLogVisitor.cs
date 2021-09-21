using UnityEngine;
using Utilities.Extensions;
using View;

namespace Utilities.Visitor
{
    public sealed class SpawnableLogVisitor : ISpawnableVisitor
    {
        private const string Asteroid = "Asteroid";
        private const string EnemyShip = "EnemyShip";
        public void Visit(AsteroidView spawnable, Transform spawnTransform)
        {
            Debug.Log($"{Asteroid} has been spawned at {spawnTransform.position.CoordinatesAsString()}");
        }

        public void Visit(EnemyShipView spawnable, Transform spawnTransform)
        {
            Debug.Log($"{EnemyShip} has been spawned at {spawnTransform.position.CoordinatesAsString()}");
        }
    }
}