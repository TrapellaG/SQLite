using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string id;
    public string itemName;
    public string itemCost;
    public string itemDescription;
    public string itemImage;

    public Item(string _id, string _itemName, string _itemCost, string _itemDescription)
    {
        id = _id;
        itemName = _itemName;
        itemCost = _itemCost;
        itemDescription = _itemDescription;
    }
}
