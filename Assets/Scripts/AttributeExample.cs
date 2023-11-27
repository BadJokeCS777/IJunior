using UnityEngine;

public class AttributeExample : MonoBehaviour
{
    [Header("Настройки стрельбы")]
    [SerializeField, Range(1f, 10f)] private float _fireRate;
    [SerializeField, Min(1)] private int _bulletsPerShoot;

    [Header("Пример работы с текстом")]
    [SerializeField, Multiline(2)] private string _itemDescription;
    [SerializeField, TextArea(1, 3)] private string _greeting;

    [Space(20)]
    [Header("Рассчёт скорости передвижения")]
    [Tooltip("Определяет степень экспоненты при рассчёте скорости")]
    [SerializeField] private float _exponentialModifier;
}