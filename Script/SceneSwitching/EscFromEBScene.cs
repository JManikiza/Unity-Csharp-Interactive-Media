using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscFromEBScene : MonoBehaviour
{


    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            try
            {
                SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("ExplodingBrick"));
            }
            catch (System.ArgumentException)
            {
                Debug.Log("Not EB");
            }
            SceneButtonSwitcher.FPCamKiller(true);

        }

        /*public void UnloadScene(int scene)
        {
            StartCoroutine(Unload(scene));
        }

        IEnumerator Unload(int scene)
        {
            yield return null;
        }*/
    }
}
