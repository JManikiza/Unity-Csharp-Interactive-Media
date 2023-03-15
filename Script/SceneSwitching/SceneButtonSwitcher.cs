using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtonSwitcher : MonoBehaviour
{

    public static GameObject fpCamera;
    public GameObject cam;




    public void CameraStart()
    {
        fpCamera = cam;
        FPCamKiller(false);
    }
    public static void FPCamKiller(bool trueOrFalse)
    {
        fpCamera.SetActive(trueOrFalse);
    }


    public void SceneLoader(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
    }
}
