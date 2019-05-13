using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public GameObject projectile;

    private GameObject _shot;
    //public Sprite[] sprites;
    public GameObject WeaponSprite;
    protected float FireRate { private get; set;}
    protected float DamagePerSecond { private get; set; }
    
    protected int MaxAmmo { get; set; }

    private int _currentAmmo;
    
    private bool _isReloading;
    
    protected float ReloadTime { private get; set; }

    private float _nextFire;

    private void Start()
    {
        _nextFire = 0f;
        _isReloading = false;
        _currentAmmo = MaxAmmo;
    }

    private void Update()
    {
        if (_isReloading)
        {
            return;
        }
        
        if (_currentAmmo <= 0 || Input.GetKeyDown(KeyCode.R) && _currentAmmo < MaxAmmo)
        {
            StartCoroutine(Reload());
            return;
        }
        
        if (Input.GetButton("Fire1") && Time.time >= _nextFire)
        {
            _nextFire = Time.time + FireRate;
            Shoot();
        }
    }

    private void Shoot()
    {
        _currentAmmo--;
        _shot = Instantiate(projectile, WeaponSprite.transform.position, Quaternion.identity);
    }

    private IEnumerator Reload()
    {
        _isReloading = true;
        yield return new WaitForSeconds(ReloadTime);
        _currentAmmo = MaxAmmo;
        _isReloading = false;
    }


}
