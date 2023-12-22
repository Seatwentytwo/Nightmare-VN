using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandwich_Collect : MonoBehaviour
{
    public bool SandwichCollected;
    Renderer rend;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        SandwichCollected = false;
        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        rend.enabled = true;
        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SandwichCollected = true;
        rend.enabled = false;
        collide.enabled = false;
    }
}
