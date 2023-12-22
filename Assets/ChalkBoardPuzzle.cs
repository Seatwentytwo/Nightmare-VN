using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkBoardPuzzle : MonoBehaviour
{
    public bool PuzzleCompleted;

    bool IsChalkCollected;

    public bool PlayerInside;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IsChalkCollected = GameObject.Find("Chalk").GetComponent<Chalk_Collect>().ChalkCollected;

        if (PlayerInside == true && Input.GetKeyDown(KeyCode.Alpha6) && IsChalkCollected == true)
        {
            PuzzleCompleted = true;
        }

        else if (PlayerInside == true && Input.GetKeyDown(KeyCode.Keypad6) && IsChalkCollected == true)
        {
            PuzzleCompleted = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerInside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerInside = false;
        }
    }
}
