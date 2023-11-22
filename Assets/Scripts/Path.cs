using DG.Tweening;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;
    
    private void Start()
    {
        Tween tween = transform.DOPath(_waypoints, 5, PathType.CatmullRom).SetLookAt(0.01f);
      
        tween.SetLoops(-1).SetEase(Ease.Linear);
    }
}