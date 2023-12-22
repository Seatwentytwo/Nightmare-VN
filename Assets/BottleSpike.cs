using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleSpike : MonoBehaviour
{
    bool PillsCollected;
    public bool SpikePunch;

    // Start is called before the first frame update
    void Start()
    {
        PillsCollected = false;
        SpikePunch = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (PillsCollected == true)
        {
            SpikePunch = true;
        }
    }
}
