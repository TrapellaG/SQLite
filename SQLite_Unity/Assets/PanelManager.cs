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
    public Button loginButton;
    public Button createUserTo;
    public Button createUser;
    public Button backToMenu;
    public Text userNotLoged;
    public Login loged = GameObject.Find("login").GetComponent<Login>();

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
        if(loged.loged == true)
        {
            mainMenu.SetActive(false);
        }
        else
        {
            userNotLoged.text = "user not loged";
        }
     
    }
}
