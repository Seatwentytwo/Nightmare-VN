using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool PickedUp;
    public bool Collect;
    public bool Collectable;
    public bool PlayerInside;
    
    public int TextNumber;
    public int TextNumberSelect;

    public GameObject Pick;

    // Start is called before the first frame update
    void Start()
    {
        PickedUp = false;
        Collect = false;
        TextNumber = 0;
        PlayerInside = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && PlayerInside == true && Collectable == true)
        {
            Collect = true;
        }

        if (Collect == true)
        {
            PickedUp = true;
            Pick.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D Player)
    {
        PlayerInside = false;
        TextNumber = 0;
    }

    void OnTriggerEnter2D(Collider2D Player)
    {
        PlayerInside = true;
        TextNumber = TextNumberSelect;
    }
}
