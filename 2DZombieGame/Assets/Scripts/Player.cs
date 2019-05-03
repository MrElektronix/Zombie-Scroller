using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterBase
{
    private SpriteRenderer _spriteRenderer;
    private void Awake()
    {
        Lives = 3;
        Speed = 8f;
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public override void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _spriteRenderer.sprite = sprites[0];
            gameObject.transform.position -= new Vector3(Speed, 0f, 0f) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _spriteRenderer.sprite = sprites[1];
            gameObject.transform.position += new Vector3(Speed, 0f, 0f) * Time.deltaTime;
        }
    }

    private void Update()
    {
        Move();
    }
}
