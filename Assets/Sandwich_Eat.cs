using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandwich_Eat : MonoBehaviour
{
    bool Sandwich_Collected;
    public bool Sandwich_Eaten;

    // Start is called before the first frame update
    void Start()
    {
        Sandwich_Collected = false;
        Sandwich_Eaten = false;
    }

    // Update is called once per frame
    void Update()
    {
        Sandwich_Collected = GameObject.Find("Sandwich").GetComponent<Sandwich_Collect>().SandwichCollected;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && Sandwich_Collected == true)
        {
            Sandwich_Eaten = true;
        }
    }
}
