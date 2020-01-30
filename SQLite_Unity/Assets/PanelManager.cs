using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public Button login;
    public Button play;
    public GameObject mainMenu;
    public GameObject loginPanel;
    public GameObject createUserPanel;
    public GameObject shop;
    public Button loginButton;
    public Button createUserTo;
    public Button createUser;
    public Button backToMenu;
    public Text userNotLoged;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        loginPanel.SetActive(false);
        createUserPanel.SetActive(false);

    }
    
    public void BackToMenu()
    {
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

    public void Play()
    {
        bool loged = false;
        /*GameObject loged = GameObject.Find("login");
        Login logins = loged.GetComponent<Login>();*/
        loged = GameObject.Find("DB").GetComponent<Login>().loged;

        if (loged == true)
        {
            userNotLoged.text = "";
            mainMenu.SetActive(false);
        }
        else
        {
            userNotLoged.text = "user not loged";
        }
     
    }
}
