using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movement;
    [SerializeField] private Rigidbody2D rigid;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private SpriteRenderer playerSprite;
    // Start is called before the first frame update
    private void OnValidate()
    {
        rigid = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }
    private void FixedUpdate()
    {
        Vector2 velocity = rigid.velocity;
        velocity.x = movement;
        rigid.velocity = velocity;
        if (movement < 0)
        {
            playerSprite.flipX = true;
        }
        else if (movement > 0)
        {
            playerSprite.flipX = false;
        }
    }
}
