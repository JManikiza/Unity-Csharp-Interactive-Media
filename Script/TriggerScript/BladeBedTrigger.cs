using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BladeBedTrigger : MonoBehaviour
{
    public GameObject blade;
    public AudioSource scream;
    public GameObject curtain;
    bool played = false;
    // Start is called before the first frame update
    void Start()
    {
        curtain.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blade") && played == false)
        {
            curtain.SetActive(true);
            scream.Play();
            played = true;
        }
    }
}
