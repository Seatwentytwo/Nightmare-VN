using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Space_Pills : MonoBehaviour
{
    bool PillsCollected;

    Image image;

    // Start is called before the first frame update
    void Start()
    {
        PillsCollected = false;

        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        PillsCollected = GameObject.Find("Pill").GetComponent<Pills_Collect>().PillsCollected;

        if (PillsCollected == true)
        {
            image.enabled = true;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            if (Input.GetKey(KeyCode.Space))
            {
                Destroy(gameObject);
            }
        }
    }
}
