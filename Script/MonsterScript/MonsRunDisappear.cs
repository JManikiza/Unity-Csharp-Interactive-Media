using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsRunDisappear : MonoBehaviour
{
    public GameObject zombieObject;
    public GameObject gameObject;
    public GameObject gameObject2;

    private void Start()
    {
        zombieObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider Player)
    {
        if(Player.tag == "Player")
        {
            zombieObject.SetActive(true);
            StartCoroutine(DestroyObject());
        }

        IEnumerator DestroyObject()
        {
            yield return new WaitForSeconds(2.0f);
            Destroy(zombieObject);
            Destroy(gameObject);
            Destroy(gameObject2);
        }
        
    }
}
