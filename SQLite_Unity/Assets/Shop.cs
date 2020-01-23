using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public bool enoughtMoney;
    public Text money;
    public Text username;

    public void Buy()
    {
        int userMoney = 0;
        GameObject db = GameObject.Find("DB");
        main main = db.GetComponent<main>();

        userMoney = main.CheckEnoughtMoney(username.text.ToString(), Int32.Parse(username.ToString()));

        if(userMoney >= Int32.Parse(money.ToString()))
        {
            userMoney = userMoney - Int32.Parse(money.ToString());
            
            main.UpdateMoney(userMoney, username.ToString());
        }
        else
        {

        }
    }
}
