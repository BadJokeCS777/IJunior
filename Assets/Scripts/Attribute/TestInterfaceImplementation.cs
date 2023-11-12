using UnityEngine;

namespace Attribute
{
    public class TestInterfaceImplementation : MonoBehaviour, ITestInterface
    {
        public void Do()
        {
            Debug.Log("Interface is work");
        }
    }
}