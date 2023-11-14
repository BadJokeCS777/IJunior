using UnityEngine;

namespace Attribute
{
    public class Unit : MonoBehaviour
    {
        [SerializeField, SerializeInterface(typeof(IMovable))] private GameObject _movableObject;
        [SerializeField, SerializeInterface(typeof(IMovable))] private GameObject[] _movableObjects;

        private IMovable _movable;

        private void Start()
        {
            _movable = _movableObject.GetComponent<IMovable>();
            _movable.Move();
        }
    }
}