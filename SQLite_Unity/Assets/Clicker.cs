using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{

    public Text clickerMoney;
    public Text player;
    public Text timerText;
    GameObject db;
    main main;
    Login login;
    PanelManager panel;
    int newMoney;
    int earnMoney;
    public float timer;
    public bool timeOut;

    // Start is called before the first frame update
    void Start()
    {
        int newMoney;
        int earnMoney;
        timeOut = false;
        timer = 20f;
        db = GameObject.Find("DB");
        main = db.GetComponent<main>();
        panel = GameObject.Find("Main Camera").GetComponent<PanelManager>();
        login = db.GetComponent<Login>();
        clickerMoney.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.smoothDeltaTime;
        timerText.text = "timer: " + timer.ToString();
        clickerMoney.text = earnMoney + "$";

        if(timer <=0)
        {
            timeOut = true;
            newMoney = earnMoney + main.CheckEnoughtMoney(player.text.ToString());
            main.UpdateMoney(newMoney, player.text.ToString());
            panel.showShop();
        }

    }

    public void MoreMoney()
    {
        if (timeOut == false)
        {
            earnMoney += 10;
        }
    }

}
