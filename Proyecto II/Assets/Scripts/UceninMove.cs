using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UceninMove : MonoBehaviour
{
    float xInicial, yInicial;

    public float runSpeed=2;
    
    public float jumpSpeed=2;

    Rigidbody2D rb2D;

    public SpriteRenderer spriteRenderer;

    public Animator animator;
    
   
    void Start()
    {
        xInicial = transform.position.x;
        yInicial = transform.position.y;
        rb2D=GetComponent<Rigidbody2D>();
    }

       
    void FixedUpdate()
    {
        mover();
        Jump();

    }



    public void Recolocar()
    {
        transform.position = new Vector3(xInicial, yInicial, 0);
        FindObjectOfType<HealthandDamage>().SendMessage("RestarVida", 1);
    }

    public void mover()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Walk", true);

        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Walk", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Walk", false);
        }
    }

    public void Jump()
    {
        if (Input.GetKey("w") && CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }

        if (CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Walk", false);

        }
        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
        }
    }
}
