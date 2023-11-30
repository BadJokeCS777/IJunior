using System;
using UnityEngine;

public class SerializeExample : MonoBehaviour
{
    [SerializeField] private Stats _stats;
    [SerializeField] private int _privateSerializeField;

    [NonSerialized] public int NonSerialized;
    [HideInInspector] public int HidenField;

    public int PublicField;
}

[Serializable]
public class Stats
{
    [SerializeField] private int _health;
    [SerializeField] private int _damage;
    [SerializeField] private bool _isAlive;
}
