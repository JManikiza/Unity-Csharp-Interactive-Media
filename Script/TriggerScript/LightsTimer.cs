using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsTimer : MonoBehaviour
{

    public GameObject torch0;
    public GameObject torch1;
    public GameObject torch2;
    public GameObject torch3;
    public GameObject torch4;
    public GameObject torch5;
    public GameObject torch6;
    public GameObject torch7;
    private void Start()
    {
     
        torch0.SetActive(false);
        torch1.SetActive(false);
        torch2.SetActive(false);
        torch3.SetActive(false);
        torch4.SetActive(false);
        torch5.SetActive(false);
        torch6.SetActive(false);
        torch7.SetActive(false);

    }
    private IEnumerator OnTriggerEnter(Collider Player)
    {
        if (Player.tag == "Player")
        {
            yield return new WaitForSeconds(7.0f);
            torch1.SetActive(true);
            torch2.SetActive(true);
            torch0.SetActive(true);

            yield return new WaitForSeconds(3.0f);

            torch3.SetActive(true);
            torch4.SetActive(true);
            torch5.SetActive(true);

            yield return new WaitForSeconds(3.0f);

            torch6.SetActive(true);
            torch7.SetActive(true);
        }

        

    }
}
