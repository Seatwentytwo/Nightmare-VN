using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxToggle : MonoBehaviour
{
    public GameObject Placeholder_Textbox;

    public bool DisplayingText;

    // Start is called before the first frame update
    void Start()
    {
        DisplayingText = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (DisplayingText == false)
        {
            Placeholder_Textbox.SetActive(false);
        }


        else if (DisplayingText == true)
        {
            Placeholder_Textbox.SetActive(true);
        }
    }
}
