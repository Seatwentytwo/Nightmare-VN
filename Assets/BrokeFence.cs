using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokeFence : MonoBehaviour
{
    Renderer rend;
    Collider2D collide;

    bool CuttersCollected;

    // Start is called before the first frame update
    void Start()
    {
        CuttersCollected = false;

        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        collide.enabled = true;
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        CuttersCollected = GameObject.Find("Fence Cutters").GetComponent<FCutters_Collect>().CutterCollected;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CuttersCollected == true && collision.gameObject.tag == "Player")
        {
            rend.enabled = true;
            collide.enabled = false;
        }
    }
}
