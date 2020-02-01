using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public bool enoughtMoney;
    public Text money;
    int money2;
    public Text username;
   // public Text notEnoughMoney;
   // public Button backToMenu;
    GameObject db;
    main main;
    int userMoney = 0;

    public void Start()
    {
        //notEnoughMoney.text = "";
        db = GameObject.Find("DB");
        main = db.GetComponent<main>();
        userMoney = main.CheckEnoughtMoney(username.text.ToString());
        money.text = userMoney.ToString() + "$";
    }

    public void GetItemPrice(int price)
    {
        Debug.Log("price2 " + price);
        money2 = price;
    }

    public void Buy()
    {
        Debug.Log("buy");
        userMoney = main.CheckEnoughtMoney(username.text.ToString());
        
        Debug.Log("price " + money2);

        if (userMoney >= money2)
        {
            userMoney = userMoney - money2;
            
            main.UpdateMoney(userMoney, username.text.ToString());
            userMoney = main.CheckEnoughtMoney(username.text.ToString());
            money.text = userMoney.ToString() + "$";
        }
        else
        {
            //notEnoughMoney.text = "not enough money";
        }
    }

}
