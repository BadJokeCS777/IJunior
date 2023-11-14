using UnityEngine;

namespace Attribute
{
    public class Unit : MonoBehaviour
    {
        [SerializeField, SerializeInterface(typeof(IMovement))] private GameObject _moveObject;
        [SerializeField, SerializeInterface(typeof(IMovement))] private GameObject[] _moveObjects;

        private void Start()
        {
            _moveObject.GetComponent<IMovement>().Move();
        }
    }
}