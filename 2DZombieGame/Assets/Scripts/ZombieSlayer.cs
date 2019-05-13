using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSlayer : Weapon{

    private void Awake()
    {
        FireRate = 0.5f;
        DamagePerSecond = 10f;
        MaxAmmo = 10;
        ReloadTime = 3f;
    }
}
