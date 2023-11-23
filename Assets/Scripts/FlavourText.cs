using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlavourText : MonoBehaviour
{
    public string Text;

    // Start is called before the first frame update
    void Start()
    {
        Text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D Player)
    {
        Text = "A cylinder?...";
    }

    public void OnTriggerExit2D(Collider2D Player)
    {
        Text = string.Empty;
    }
}
