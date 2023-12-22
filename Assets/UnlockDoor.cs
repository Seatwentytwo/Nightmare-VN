using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    bool ChalkBoardComplete;
    Renderer rend;
    Collider2D collide;

    // Start is called before the first frame update
    void Start()
    {
        ChalkBoardComplete = false;
        rend = GetComponent<Renderer>();
        collide = GetComponent<Collider2D>();

        rend.enabled = false;
        collide.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        ChalkBoardComplete = GameObject.Find("Chalkboard").GetComponent<ChalkBoardPuzzle>().PuzzleCompleted;

        if (ChalkBoardComplete == true)
        {
            rend.enabled = true;
            collide.enabled = false;
        }
    }
}
