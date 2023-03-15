using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public ItemScript item;

    void Obtain()
    {
        InventManager.instance.Add(item);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Obtain();
    }

}
