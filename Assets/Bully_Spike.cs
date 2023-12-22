using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bully_Spike : MonoBehaviour
{
    bool Spiked;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        Spiked = false;
        collide = GetComponent<Collider2D>();

        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Spiked = GameObject.Find("Bottle").GetComponent<BottleSpike>().SpikePunch;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Spiked == true)
        {
            collide.enabled = false;
        }
    }
}
