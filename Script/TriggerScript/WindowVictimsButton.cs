using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowVictimsButton : MonoBehaviour

{
    public GameObject spotlight;
    public GameObject key;
    public Animator anima;
    public GameObject curtain;
    public bool pressed = false;


    // Start is called before the first frame update
    void Start()
    {
        spotlight.SetActive(false);
        key.SetActive(false);
        anima.enabled = false;
    }

    // Update is called once per frame

    void Update()
    {

    }

    public void ButtonClick()
    {
        if (pressed == false)
        {
            spotlight.SetActive(true);
            anima.enabled = true;
            pressed = true;



        }
        else if (pressed == true)
        {
            anima.enabled = false;
            key.SetActive(true);
            spotlight.SetActive(false);
            curtain.SetActive(true);
            pressed = false;


        }
    }
}
    

    

