using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject Torch;
    // Start is called before the first frame update
    void Start()
    {

        Torch.SetActive(false);

    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider player)
    {

        Torch.SetActive(true);

    }

}
