using UnityEngine;

[SelectionBase]
[RequireComponent(typeof(Rigidbody))]
public class PhysicalMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(transform.forward * _speed, ForceMode.VelocityChange);
    }
}