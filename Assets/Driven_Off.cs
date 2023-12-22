using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driven_Off : MonoBehaviour
{
    bool DrivenOff;

    Renderer rend;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        DrivenOff = false;

        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        rend.enabled = true;
        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        DrivenOff = GameObject.Find("SandwichMan").GetComponent<Sandwich_Eat>().Sandwich_Eaten;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rend.enabled = false;
        collide.enabled = false;
    }
}
