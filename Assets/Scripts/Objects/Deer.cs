using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : MonoBehaviour
{
    bool PlayerDetected;
    public bool DeerIsDead;
    public bool TrapPlaced;
    Animator animator;

    Renderer rend;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        animator = GetComponent<Animator>();

        PlayerDetected = false;

        rend.enabled = true;
        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDetected = GameObject.Find("Deer Detect").GetComponent<Deer_Detection>().PlayerDetected;
        TrapPlaced = GameObject.Find("PlacedBeartrap").GetComponent<Beartrap_DeerKill>().TrapActivated;

        animator.SetBool("PlayerDetected", PlayerDetected);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Item" && TrapPlaced == true)
        {
            DeerIsDead = true;

            rend.enabled = false;
            collide.enabled = false;
        }
    }
}
