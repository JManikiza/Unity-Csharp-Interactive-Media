using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteTriggerUI : MonoBehaviour  
{

    public Image image;
    public Image buttonPrompt;
    public Image exitPrompt;

    public void Start()
    {
        image.enabled = false;
        buttonPrompt.enabled = false;
        exitPrompt.enabled = false;
    }
    public void OnTriggerEnter(Collider Player)
    {
        if (buttonPrompt.enabled == false)
        {
            buttonPrompt.enabled = true;
            Debug.Log("first if statement works");
        }

    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("It worked pressing E");
            buttonPrompt.enabled = false;
            image.enabled = true;
            exitPrompt.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("it worked pressing esc");
            buttonPrompt.enabled = true;
            image.enabled = false;
            exitPrompt.enabled = false;
        }


    }

    void OnTriggerExit(Collider Player)
    {
        Debug.Log("exit trigger works");
        image.enabled = false;
        buttonPrompt.enabled = false;
        exitPrompt.enabled = false;
        
    }

}