using UnityEngine;

public class ForcePusher : MonoBehaviour
{
    [SerializeField] private float _force; 

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.down * _force);
    }
}
