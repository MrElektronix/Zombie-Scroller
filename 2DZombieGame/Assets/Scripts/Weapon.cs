using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public GameObject projectile;
    //public Sprite[] sprites;
    public GameObject WeaponSprite;
    protected float FireRate { private get; set;}
    protected bool CanShoot { private get; set;}
    protected float DamagePerSecond { private get; set; }

    private void Awake()
    {
        CanShoot = true;
    }

    protected void FireProjectile()
    {
        if (!Input.GetKey(KeyCode.Space) || !CanShoot) return;
        var proj = Instantiate(projectile, WeaponSprite.transform.position, Quaternion.identity);
        CanShoot = false;
        StartCoroutine(Shoot(FireRate));
    }

    private IEnumerator Shoot(float timeToShoot)
    {
        while (!CanShoot)
        {
            yield return new WaitForSeconds(timeToShoot);
            CanShoot = true;
        }
    }

}
