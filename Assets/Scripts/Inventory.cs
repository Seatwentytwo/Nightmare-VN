using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool KeyCollected;
    public GameObject Key;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        KeyCollected = Key.GetComponent<Pickup>().PickedUp;
    }
}
