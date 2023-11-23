using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private FootStepsSounds _stepsSounds;

    private void Update()
    {
        Rotate();
        Move();
    }

    private void Rotate()
    {
        float rotation = Input.GetAxis("Horizontal");

        transform.Rotate(_rotationSpeed * rotation * Time.deltaTime * Vector3.up);
    }

    private void Move()
    {
        float direction = Input.GetAxis("Vertical");

        if (direction != 0f)
        {
            transform.Translate(_moveSpeed * direction * Time.deltaTime * Vector3.forward);

            if (_stepsSounds.IsPlaying == false)
                _stepsSounds.Play();
        }
        else
        {
            if (_stepsSounds.IsPlaying)
                _stepsSounds.Pause();
        }
    }
}