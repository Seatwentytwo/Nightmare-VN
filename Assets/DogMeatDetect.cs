using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMeatDetect : MonoBehaviour
{
    bool MeatCollected;
    Renderer rend;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        MeatCollected = false;

        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        rend.enabled = true;
        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        MeatCollected = GameObject.Find("Meat").GetComponent<Meat_Collect>().MeatCollected;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (MeatCollected && collision.gameObject.tag == "Player")
        {
            rend.enabled = false;
            collide.enabled = false;
        }
    }
}
