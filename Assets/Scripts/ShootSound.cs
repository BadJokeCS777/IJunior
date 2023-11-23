using UnityEngine;

public class ShootSound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void Play()
    {
        _audioSource.Play();
    }
}
