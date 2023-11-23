using UnityEngine;

public class AmbientSoundZone : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    [SerializeField] private AmbientSound _ambientSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() == false)
            return;

        _ambientSound.SetClip(_clip);
    }
}
