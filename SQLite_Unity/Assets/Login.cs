using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public Button loginUser;
    public Text username;
    public Text password;
    public Text usernameLoged;
    public GameObject wrongUser;
    public GameObject shopPanel;
    public GameObject loginPanel;
    PanelManager panel;
    public bool loged;

    private void Start()
    {
        panel = GameObject.Find("Main Camera").GetComponent<PanelManager>();
        wrongUser.SetActive(false);
    }

    public void LoginSendParamsToDB()
    {
        bool userExist = false;
        GameObject db = GameObject.Find("DB");
        main main = db.GetComponent<main>();

        userExist = main.CheckLogin(username.text.ToString(), password.text.ToString());

        if (userExist == true)
        {
            Debug.Log("exist");
            panel.showShop();
            loged = true;
            usernameLoged.text = username.text.ToString();
        }
        else
        {
            Debug.Log("no exist");
            wrongUser.SetActive(true);
        }
    }
}
