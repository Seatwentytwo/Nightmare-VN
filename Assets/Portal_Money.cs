using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal_Money : MonoBehaviour
{
    bool MoneyCollected;
    Renderer rend;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        MoneyCollected = false;
        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        rend.enabled = false;
        collide.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        MoneyCollected = GameObject.Find("Money").GetComponent<MoneyCollect>().MoneyCollected;

        if (MoneyCollected == true)
        {
            rend.enabled = true;
            collide.enabled = true;
        }
    }
}
