using UnityEngine;

namespace Attribute
{
    public class Unit : MonoBehaviour
    {
        [SerializeField, SerializeInterface(typeof(IMove))] private GameObject _moveObject;
        [SerializeField, SerializeInterface(typeof(IMove))] private GameObject[] _moveObjects;

        private void Start()
        {
            _moveObject.GetComponent<IMove>().Move();
        }
    }
}