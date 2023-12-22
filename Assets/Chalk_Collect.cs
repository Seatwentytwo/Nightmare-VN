using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chalk_Collect : MonoBehaviour
{
    public bool ChalkCollected;
    Renderer rend;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        ChalkCollected = false;
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
        ChalkCollected = true;
        rend.enabled = false;
        collide.enabled = false;
    }
}
