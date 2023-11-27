using UnityEngine;

public class DelayedExample : MonoBehaviour
{
    [SerializeField, Delayed] private float _yPosition;

    private void Update()
    {
        transform.position = new Vector3(0f, _yPosition, 0f); 
    }
}
