﻿using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private ShootSound _shootSound;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }

    private void Shoot()
    {
        Debug.Log("Shoot");

        _shootSound.Play();
    }
}