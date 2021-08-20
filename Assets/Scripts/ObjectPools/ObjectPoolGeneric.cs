using System.Collections.Generic;
using UnityEngine;

namespace ObjectPools
{
    public class ObjectPool<T> : ObjectPool
        where T : Component
    {
        private readonly Stack<T> _stack = new Stack<T>();
        private readonly T _prefab;

        public ObjectPool(T prefab)
        {
            _prefab = prefab;
        }
        
        public override void Push(Component prefab)
        {
            PushIntoStack(prefab as T);
        }
        
        public override Component Pop()
        {
            return PopFromStack();
        }

        private void PushIntoStack(T go)
        {
            _stack.Push(go);
            go.gameObject.SetActive(false);
        }

        private T PopFromStack()
        {
            var go = _stack.Count == 0 ? Object.Instantiate(_prefab) : _stack.Pop();
            go.gameObject.SetActive(true);
            
            return go;
        }

        
    }
}