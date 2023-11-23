using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool PickedUp;
    public bool Collect;
    public bool PlayerInside;
    public int TextNumber;
    public string Text;

    public GameObject Pick;
    public GameObject TextBox;

    // Start is called before the first frame update
    void Start()
    {
        PickedUp = false;
        Collect = false;
        TextNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && PlayerInside == true)
        {
            Collect = true;
        }

        if (Collect == true)
        {
            PickedUp = true;
            TextBox.SetActive(true);
            Pick.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D Player)
    {
        Text = string.Empty;
        PlayerInside = false;
    }

    void OnTriggerEnter2D(Collider2D Player)
    {
        PlayerInside = true;
    }

    void OnTriggerStay2D(Collider2D Player)
    {
        Text = "A Key";
    }
}
