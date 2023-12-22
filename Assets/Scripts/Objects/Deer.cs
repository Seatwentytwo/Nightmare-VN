using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : MonoBehaviour
{
    bool PlayerDetected;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        PlayerDetected = false;
        animator.SetBool("PlayerDetected", PlayerDetected);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDetected = GameObject.Find("Deer Detect").GetComponent<Deer_Detection>().PlayerDetected;
    }
}
