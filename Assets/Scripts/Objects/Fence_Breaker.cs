using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence_Breaker : MonoBehaviour
{
    bool FenceCuttersCollected;

    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        FenceCuttersCollected = false;

        collide = GetComponent<Collider2D>();

        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        FenceCuttersCollected = GameObject.Find("Fence Cutters").GetComponent<FCutters_Collect>().CutterCollected;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (FenceCuttersCollected == true && collision.gameObject.tag == "Player")
        {
            collide.enabled = false;
        }
    }
}
