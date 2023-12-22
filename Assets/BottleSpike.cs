using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleSpike : MonoBehaviour
{
    bool PillsCollected;
    public bool SpikePunch;
    bool Punch_Collected;

    // Start is called before the first frame update
    void Start()
    {
        PillsCollected = false;
        SpikePunch = false;
        Punch_Collected = false;
    }

    // Update is called once per frame
    void Update()
    {
        PillsCollected = GameObject.Find("Pill").GetComponent<Pills_Collect>().PillsCollected;
        Punch_Collected = GameObject.Find("Punch").GetComponent<Punch_Collect>().PunchCollected;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (PillsCollected == true && Punch_Collected == true)
        {
            SpikePunch = true;
        }
    }
}
