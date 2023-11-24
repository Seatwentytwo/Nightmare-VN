using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBoxToggle : MonoBehaviour
{
    public Image PlaceHolder_Image;

    public GameObject Text;

    public bool DisplayingText;

    // Start is called before the first frame update
    void Start()
    {
        DisplayingText = false;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayingText = Text.GetComponent<TextBox>().OpenTextbox;

        if (DisplayingText == false)
        {
            PlaceHolder_Image.enabled = false;
        }


        else if (DisplayingText == true)
        {
            PlaceHolder_Image.enabled = true;
        }
    }
}
