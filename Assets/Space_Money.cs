using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Space_Money : MonoBehaviour
{
    bool MoneyCollected;

    Image image;

    // Start is called before the first frame update
    void Start()
    {
        MoneyCollected = false;

        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        MoneyCollected = GameObject.Find("Money").GetComponent<MoneyCollect>().MoneyCollected;

        if (MoneyCollected == true)
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
