using UnityEngine;

public class TestInterfaceImplementation : MonoBehaviour, ITestInterface
{
    public void Do()
    {
        Debug.Log("Interface is work");
    }
}