using UnityEngine;

namespace ObjectPools
{
    public abstract class ObjectPool
    {
        public abstract Component Pop();
        public abstract void Push(Component prefab);
    }
}