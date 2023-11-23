﻿using System;
using UnityEngine;

[Serializable]
public struct FootStepsSound
{
    [SerializeField] private SurfaceType _type;
    [SerializeField] private AudioClip _clip;

    public SurfaceType Type => _type;
    public AudioClip Clip => _clip;
}