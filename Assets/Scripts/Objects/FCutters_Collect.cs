using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCutters_Collect : MonoBehaviour
{
    public bool CutterCollected;
    Renderer rend;
    Collider2D collide;
    AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        CutterCollected = false;
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
        CutterCollected = true;
        rend.enabled = false;
        collide.enabled = false;
        Audio.Play();
    }
}
