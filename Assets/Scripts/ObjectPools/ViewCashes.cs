using System.Collections.Generic;
using UnityEngine;

namespace ObjectPools
{
    public class ViewCashes
    {
        private readonly Dictionary<string, ObjectPool> _pools = new Dictionary<string, ObjectPool>(10);

        public T Create<T>(Component prefab) where T : Component
        {
            if (!_pools.TryGetValue(prefab.name, out var pool))
            {
                pool = new ObjectPool<T>(prefab as T);
                _pools[prefab.name] = pool;
            }

            return pool.Pop() as T;
        }

        public void Destroy<T>(T prefab) where T : Component
        {
            _pools[prefab.name].Push(prefab);
        }
    }
}