using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenPlatform : Platform
{
    private Animator anim;
    private Rigidbody2D rigid;
    private BoxCollider2D colli;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        colli = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            anim.SetBool("isBroke", true);
            rigid.gravityScale = 1;
            colli.isTrigger = true;
        }
    }
}
