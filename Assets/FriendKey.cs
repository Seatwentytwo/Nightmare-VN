using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendKey : MonoBehaviour
{
    bool FriendCollected;
    Renderer rend;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        FriendCollected = false;
        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        rend.enabled = false;
        collide.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        FriendCollected = GameObject.Find("Friend").GetComponent<FriendCollect>().FriendCollected;

        if (FriendCollected == true)
        {
            rend.enabled = true;
            collide.enabled = true;
        }
    }
}
