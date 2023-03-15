using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscFromCharController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            try
            {
                SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("CharController"));
            }
            catch (System.ArgumentException)
            {
                Debug.Log("Not CC");
            }
            SceneButtonSwitcher.FPCamKiller(true);

        }
    }
}