using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Projectile : MonoBehaviour
{
    private float _velocity;
    private float _destroyAfterSeconds;
    private void Awake()
    {
        _velocity = 10f;
        _destroyAfterSeconds = 3f;
    }

    private void Start()
    {
        StartCoroutine(DestroyProjectileTimer());
    }

    private void Update()
    {
        MoveProjectile();
    }

    private void MoveProjectile()
    {
        gameObject.transform.position -= new Vector3(_velocity, 0f, 0f) * Time.deltaTime;
    }

    private IEnumerator DestroyProjectileTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(_destroyAfterSeconds);
            Destroy(gameObject);
        }
    }
}
