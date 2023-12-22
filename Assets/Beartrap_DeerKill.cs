using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beartrap_DeerKill : MonoBehaviour
{
    Renderer rend;
    Collider2D collide;
    AudioSource Audio;

    bool TrapCollected;
    public bool TrapActivated;
    bool DeerKilled;

    // Start is called before the first frame update
    void Start()
    {
        TrapCollected = false;
        TrapActivated = false;
        DeerKilled = false;

        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();
        Audio = GetComponent<AudioSource>();

        collide.enabled = true;
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        TrapCollected = GameObject.Find("Beartrap").GetComponent<Beartrap_collect>().TrapCollected;
        DeerKilled = GameObject.Find("Deer").GetComponent<Deer>().DeerIsDead;

        if (DeerKilled == true)
        {
            rend.enabled = false;
            collide.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (TrapCollected == true && collision.gameObject.tag == "Player")
        {
            rend.enabled = true;
            collide.enabled = true;
            TrapActivated = true;
            Audio.Play();
        }
    }
}
