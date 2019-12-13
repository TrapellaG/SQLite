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

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        loginPanel.SetActive(false);
        createUserPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
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
}
