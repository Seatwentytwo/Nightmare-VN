using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool PickedUp;
    public bool Collect;
    public string Text;
    public GameObject Pick;

    // Start is called before the first frame update
    void Start()
    {
        PickedUp = false;
        Collect = false;
        Text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D Player)
    {
        Text = "A Key";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Collect = true;
        }

        if (Collect == true)
        {
            PickedUp = true;
            Pick.SetActive(false);
        }
    }
}
