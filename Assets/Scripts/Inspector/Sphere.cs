using UnityEngine;

namespace Inspector
{
    public class Sphere : MonoBehaviour
    {
        private const float DefaultRadius = 1f;
        
        [SerializeField] private float _radius = 1f;

        private void Start()
        {
            transform.localScale = Vector3.one * _radius;
        }

        public void ResetRadius()
        {
            _radius = DefaultRadius;
        }
    }
}