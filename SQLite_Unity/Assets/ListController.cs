using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListController : MonoBehaviour
{
    public GameObject ContentPanel;
    public GameObject ListItemPrefab;
    public Text money;

    // Start is called before the first frame update
    void Start()
    {
        GameObject db = GameObject.Find("DB");
        main main = db.GetComponent<main>();
        main.SetItems();

        foreach (Item item in main.items)
        {
            Debug.Log(item.itemName);
            GameObject newItem = Instantiate(ListItemPrefab) as GameObject;
            List controller = newItem.GetComponent<List>();
            controller.itemName.text = item.itemName;
            controller.itemDescription.text = item.itemDescription;
            controller.cost.text = item.itemCost;
            newItem.transform.parent = ContentPanel.transform;
            newItem.transform.localScale = Vector3.one;
        }
    }
}
