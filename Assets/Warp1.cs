using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp1 : MonoBehaviour
{
    public GameObject WarpExit;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player.transform.position = WarpExit.transform.position;
        }
    }
}
