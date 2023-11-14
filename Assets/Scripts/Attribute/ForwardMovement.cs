using UnityEngine;

namespace Attribute
{
    public class ForwardMovement : MonoBehaviour, IMovable
    {
        [SerializeField] private float _step = 10;

        public void Move()
        {
            transform.Translate(transform.forward * _step);
            Debug.Log("Unit has been moved forward");
        }
    }
}