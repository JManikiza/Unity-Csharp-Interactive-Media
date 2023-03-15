using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{

    public AudioClip playSound;
    public float Volume;
    AudioSource audioToPlay;
    public bool alreadyPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        audioToPlay = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        if (!alreadyPlayed)
        {
            audioToPlay.PlayOneShot(playSound, Volume);
            alreadyPlayed = true;
        }
    }
}
