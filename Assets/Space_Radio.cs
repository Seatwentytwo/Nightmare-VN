using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Space_Radio : MonoBehaviour
{
    bool RadioCollected;

    Image image;

    // Start is called before the first frame update
    void Start()
    {
        RadioCollected = false;

        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        RadioCollected = GameObject.Find("Radio").GetComponent<Radio_Key>().PickedUp;

        if (RadioCollected == true)
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
