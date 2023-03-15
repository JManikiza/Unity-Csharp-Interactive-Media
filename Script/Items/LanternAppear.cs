using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternAppear : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject MenuLantern;
    public GameObject lantern;



    void Start()
    {

 
            lantern.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnClick()
        {
            lantern.SetActive(true);
        }

    }



}
