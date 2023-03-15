using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{

    public GameObject invent;
    public bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        invent.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (isPaused)
            {
                closeInvent();
            }
            else
            {
                openInvent();
            }
        }

    }

    public void openInvent()
    {
        invent.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void closeInvent()
    {
        invent.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
