using ObjectPools;
using UnityEngine;

namespace Test
{
    public class Test : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody; 
        [SerializeField] private Transform _transform; 
        private void Start()
        {
            Main();
        }

        private void Main()
        {
            var cashes = new ViewCashes();
            var rb = cashes.Create<Rigidbody2D>(_rigidbody);
            var tf = cashes.Create<Transform>(_transform);
            Debug.Log(rb.GetType());
            Debug.Log(tf.GetType());
        }
    }
}