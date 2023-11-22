using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SplineFollower follower))
        {
            Debug.Log("Collided");
        }
    }
}