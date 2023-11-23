using System.Linq;
using UnityEngine;

public class FootStepsSounds : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private FootStepsSound[] _stepsSounds;
    [SerializeField] private Transform _checkPoint;

    private SurfaceType _lastSurface;

    public bool Enabled { get; private set; }

    private void Start()
    {
        UpdateSurface(SurfaceType.Ground);
        Disable();
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(_checkPoint.position, Vector3.down, out RaycastHit hitInfo) == false)
            return;

        if (hitInfo.transform.TryGetComponent(out Surface surface) == false)
            return;

        if (surface.Type == _lastSurface)
            return;

        UpdateSurface(surface.Type);

        if (Enabled)
            _audioSource.Play();
    }

    public void Enable()
    {
        Enabled = true;
        _audioSource.Play();
    }

    public void Disable()
    {
        Enabled = false;
        _audioSource.Pause();
    }

    private void UpdateSurface(SurfaceType type)
    {
        _lastSurface = type;
        _audioSource.clip = _stepsSounds.First(sound => sound.Type == _lastSurface).Clip;
    }
}
