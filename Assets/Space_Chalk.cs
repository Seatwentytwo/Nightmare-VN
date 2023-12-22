using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Space_Chalk : MonoBehaviour
{
    bool ChalkCollected;

    Image image;

    // Start is called before the first frame update
    void Start()
    {
        ChalkCollected = false;

        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        ChalkCollected = GameObject.Find("Chalk").GetComponent<Chalk_Collect>().ChalkCollected;

        if (ChalkCollected == true)
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
