using UnityEngine;

public class AttributeExample : MonoBehaviour
{
    [Header("��������� ��������")]
    [SerializeField, Range(1f, 10f)] private float _fireRate;
    [SerializeField, Min(1)] private int _bulletsPerShoot;

    [Header("������ ������ � �������")]
    [SerializeField, Multiline(2)] private string _itemDescription;
    [SerializeField, TextArea(1, 3)] private string _greeting;

    [Space(20)]
    [Header("������� �������� ������������")]
    [Tooltip("���������� ������� ���������� ��� �������� ��������")]
    [SerializeField] private float _exponentialModifier;
}