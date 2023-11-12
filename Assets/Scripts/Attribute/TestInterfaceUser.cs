using UnityEngine;

namespace Attribute
{
    public class TestInterfaceUser : MonoBehaviour
    {
        [SerializeField, SerializeInterface(typeof(ITestInterface))] private GameObject _interfaceObject;
        [SerializeField, SerializeInterface(typeof(ITestInterface))] private GameObject[] _interfaceObjects;

        private void Start()
        {
            _interfaceObject.GetComponent<ITestInterface>().Do();
        }
    }
}