using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBox : MonoBehaviour
{
    public TMP_Text Text;
    public int CurrentText;

    public bool OpenTextbox;
    public bool PlayerReading;

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;

    // Start is called before the first frame update
    void Start()
    {
        Text.text = null;
        CurrentText = 0;
        OpenTextbox = false;
        PlayerReading = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*CurrentText = Text1.GetComponent<Pickup>().TextNumber;
        CurrentText = Text2.GetComponent<Pickup>().TextNumber;
        CurrentText = Text3.GetComponent<Pickup>().TextNumber;
        CurrentText = Text4.GetComponent<Pickup>().TextNumber;*/
        if (PlayerReading == false)
        {
            CurrentText = 0;
            OpenTextbox = false;
        }

        if (CurrentText == 0)
        {
            CurrentText += Text1.GetComponent<Pickup>().TextNumber;
            CurrentText += Text2.GetComponent<Pickup>().TextNumber;
            CurrentText += Text3.GetComponent<Pickup>().TextNumber;
            CurrentText += Text4.GetComponent<Pickup>().TextNumber;

            //CurrentText = GameObject.Find("Inspect").GetComponent<Pickup>().TextNumber;

            //CurrentText = Text1.GetComponent<Pickup>().TextNumber;
        }

        if (CurrentText != 0)
        {
            OpenTextbox = true;
        }


        ProtoText();
    }

    void ProtoText()
    {
        switch (CurrentText)
        {
            case 1:
                Text.text = "The door is locked...";
                break;

            case 2:
                Text.text = "Oh! A key?";
                break;

            case 3:
                Text.text = "It reads: Press SPACE to collect!";
                break;

            case 4:
                Text.text = "My lunch money! Who took it?";
                break;

            default:
                Text.text = null;
                break;
        }
    }
}
