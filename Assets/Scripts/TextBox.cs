using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBox : MonoBehaviour
{
    public TMP_Text Text;
    public int CurrentText;

    // Start is called before the first frame update
    void Start()
    {
        Text.text = null;
        CurrentText = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ProtoText()
    {
        switch (CurrentText)
        {
            case 0:
                Text.text = "A floating cylinder?";
                break;

            case 1:
                Text.text = "Oh! A key?";
                break;

            default:
                Text.text = null;
                break;
        }
    }
}
