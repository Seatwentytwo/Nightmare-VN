using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pills_Collect : MonoBehaviour
{
    public bool Pills_Collected;
    public Component[] Renderer;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        Pills_Collected = false;

        Renderer = gameObject.GetComponentsInChildren<Renderer>();

        //Renderer.enabled = true;
        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Pills_Collected = true;
        //Renderer.enabled = false;
        collide.enabled = false;
    }
}
