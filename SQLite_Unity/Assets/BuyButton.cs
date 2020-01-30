using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    GameObject db;
    Shop shop;
    public Button buyButton;
    public Text price;
    int price2;

    // Start is called before the first frame update
    void Start()
    {
        price2 = 0;
        db = GameObject.Find("shop");
        shop = db.GetComponent<Shop>();
    }

    public void Shop()
    {
        shop.GetItemPrice(price2);
        shop.Buy();
    }

    void Update()
    {
        int.TryParse(price.text, out price2);
        Debug.Log(price2);
    }
}
