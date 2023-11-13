using UnityEngine;

namespace Inspector
{
    public class Sphere : MonoBehaviour
    {
        [SerializeField] private float _radius = 1f;

        private void Start()
        {
            transform.localScale = Vector3.one * _radius;
        }
    }
}