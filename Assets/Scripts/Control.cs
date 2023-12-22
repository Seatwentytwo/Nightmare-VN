using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Rigidbody2D body;

    Animator animator;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public bool PlayerWalking;

    public float runSpeed = 20.0f;

    public bool Paused;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        Paused = false;
        PlayerWalking = false;
    }

    void Update()
    {
        animator.SetBool("PlayerWalking", PlayerWalking);

        if (Paused != true)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) 
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;

            PlayerWalking = true;
        }

        else if (horizontal != 0 || vertical != 0)
        {
            PlayerWalking = true;
        }

        else
        {
            PlayerWalking = false;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}