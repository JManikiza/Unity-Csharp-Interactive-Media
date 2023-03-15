using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelsMove : MonoBehaviour
{
    public GameObject AngelsAppear;
    public GameObject AngelsDisappear;

    // Start is called before the first frame update
    void Start()
    {

        AngelsAppear.SetActive(false);
        AngelsDisappear.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        AngelsAppear.SetActive(true);
        AngelsDisappear.SetActive(false);

    }
}
