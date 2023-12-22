using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat_Collect : MonoBehaviour
{
    public bool MeatCollected;
    bool DeerDied;

    Renderer rend;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        MeatCollected = false;
        DeerDied = false;

        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        rend.enabled = false;
        collide.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        DeerDied = GameObject.Find("Deer").GetComponent<Deer>().DeerIsDead;

        if (DeerDied == true && MeatCollected == false)
        {
            rend.enabled = true;
            collide.enabled = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        MeatCollected = true;
        rend.enabled = false;
        collide.enabled = false;
    }
}
