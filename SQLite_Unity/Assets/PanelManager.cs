using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public Button login;
    public GameObject mainMenu;
    public GameObject loginPanel;
    public GameObject createUserPanel;
    public GameObject clickerMoney;
    public GameObject shop;
    public GameObject clicker;
    public GameObject buttonClicker;
    public GameObject timer;
    public GameObject clickerButton;
    public GameObject username;
    public Button loginButton;
    public Button createUserTo;
    public Button createUser;
    public Button backToMenu;
    public Text userNotLoged;
    GameObject db;
    main main;
    bool loged = false;

    // Start is called before the first frame update
    void Start()
    {
        db = GameObject.Find("DB");
        main = db.GetComponent<main>();
        mainMenu.SetActive(true);
        loginPanel.SetActive(false);
        createUserPanel.SetActive(false);
    }
    
    public void BackToMenu()
    {
        username.SetActive(false);
        loginPanel.SetActive(false);
        createUserPanel.SetActive(false);
        shop.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void showLoginPanel()
    {
        mainMenu.SetActive(false);
        loginPanel.SetActive(true);
    }

    public void showCreateUserPanel()
    {
        loginPanel.SetActive(false);
        createUserPanel.SetActive(true);
    }

    public void showShop()
    {
        main.CheckEnoughtMoney(username.ToString());
        username.SetActive(true);
        clickerMoney.SetActive(false);
        clickerButton.SetActive(false);
        clicker.SetActive(false);
        timer.SetActive(false);
        buttonClicker.SetActive(false);
        loginPanel.SetActive(false);
        createUserPanel.SetActive(false);
        mainMenu.SetActive(false);
        shop.SetActive(true);
    }


    public void Play()
    {
        loged = GameObject.Find("DB").GetComponent<Login>().loged;

        clickerMoney.SetActive(true);
        clickerButton.SetActive(true);
        timer.SetActive(true);
        userNotLoged.text = "";
        mainMenu.SetActive(false);
        shop.SetActive(false);
        clicker.SetActive(true);     
    }
}
