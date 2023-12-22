using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio_Key : MonoBehaviour
{
    Renderer rend;
    Collider2D collide;
    public bool PickedUp;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        PickedUp = false;
        rend.enabled = true;
        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PickedUp = true;
        rend.enabled = false;
        collide.enabled = false;
    }
}
