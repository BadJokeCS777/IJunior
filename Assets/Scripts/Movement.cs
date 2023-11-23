using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private FootStepsSounds _stepsSounds;

    private void Update()
    {
        float direction = Input.GetAxis("Vertical");

        if (Math.Abs(direction) > 0f)
        {
            transform.Translate(_moveSpeed * direction * Time.deltaTime * Vector3.forward);

            if (_stepsSounds.Enabled == false)
                _stepsSounds.Enable();
        }
        else
        {
            if (_stepsSounds.Enabled)
                _stepsSounds.Disable();
        }

        float rotation = Input.GetAxis("Horizontal");

        if (Math.Abs(rotation) > 0f)
            transform.Rotate(rotation * _rotationSpeed * Time.deltaTime * Vector3.up);
    }
}