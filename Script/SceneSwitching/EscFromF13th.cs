using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscFromF13th : MonoBehaviour
{

        void OnTriggerStay() {
            if (Input.GetKeyDown(KeyCode.E))
            {

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

                try
                {
                    SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("SampleScene"));
                }
                catch (System.ArgumentException)
                {
                    Debug.Log("Not SampleScene");
                }
                SceneButtonSwitcher.FPCamKiller(true);
            }
        }
    
}
