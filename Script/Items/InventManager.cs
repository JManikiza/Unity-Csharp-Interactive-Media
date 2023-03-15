using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventManager : MonoBehaviour
{ 
    public static InventManager instance;
    public List<ItemScript> Items = new List<ItemScript>();
    public Transform itemContent;
    public GameObject inventoryItem;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    public void Add(ItemScript Item)
    {
        Items.Add(Item);
    }

    public void Remove(ItemScript Item)
    {
        Items.Remove(Item);
    }

    public void ObtainItems()
    {
        foreach(Transform Item in itemContent)
        {
            Destroy(Item.gameObject);
        }
        foreach(var Item in Items)
        {
            GameObject obj = Instantiate(inventoryItem, itemContent);
            var ItemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var ItemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            
            ItemName.text = Item.itemName;
            ItemIcon.sprite = Item.icon;

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            ObtainItems();
        }
    }


}

