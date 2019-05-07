using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSlayer : Weapon{

    private void Awake()
    {
        CanShoot = true;
        FireRate = 0.2f;
        DamagePerSecond = 10f;
    }
    
    private void Update()
    {
        base.FireProjectile();
    }
}
