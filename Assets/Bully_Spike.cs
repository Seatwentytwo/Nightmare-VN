using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bully_Spike : MonoBehaviour
{
    bool Spiked;
    bool Punch;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        Spiked = false;
        Punch = false;
        collide = GetComponent<Collider2D>();

        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Spiked = GameObject.Find("Pill").GetComponent<Pills_Collect>().PillsCollected;
        Punch = GameObject.Find("Punch").GetComponent<Punch_Collect>().PunchCollected;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Spiked == true && Punch == true)
        {
            collide.enabled = false;
        }
    }
}
