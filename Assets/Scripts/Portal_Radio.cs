using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_Radio : MonoBehaviour
{
    bool RadioCollected;
    Renderer rend;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        RadioCollected = false;   
        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        rend.enabled = false;
        collide.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        RadioCollected = GameObject.Find("Radio").GetComponent<Radio_Key>().PickedUp;

        if (RadioCollected == true)
        {
            rend.enabled = true;
            collide.enabled = true;
        }
    }
}
