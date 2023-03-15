using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Item", menuName ="Item/Create New Item")]
public class ItemScript : ScriptableObject
{

    public int id;
    public string itemName;
    public int value;
    public Sprite icon;

}
