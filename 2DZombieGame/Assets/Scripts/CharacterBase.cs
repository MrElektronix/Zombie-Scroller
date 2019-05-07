using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public abstract class CharacterBase : MonoBehaviour
{
    public Sprite[] sprites;
    
    protected int Lives { get; set; }
    protected float Speed { get; set; }
    
    public abstract void Move();
}
