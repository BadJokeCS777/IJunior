using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    
    private void Start()
    {
        _slider.DOValue(1, 2).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}