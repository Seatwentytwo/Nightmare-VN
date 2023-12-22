using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch_Collect : MonoBehaviour
{
    public bool PunchCollected;
    Renderer rend;
    Collider2D collide;
    AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        PunchCollected = false;
        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();
        Audio = GetComponent<AudioSource>();

        rend.enabled = true;
        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PunchCollected = true;
        rend.enabled = false;
        collide.enabled = false;
        Audio.Play();
    }
}
