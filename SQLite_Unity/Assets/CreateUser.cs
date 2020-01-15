using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateUser : MonoBehaviour
{
    public Button createUser;
    public Text name;
    public Text username;
    public Text password;
    public Text repeatPassword;
    public Text userCreated;

    private void Start()
    {
        userCreated.text = "";
    }

    public void SendParamsToDB()
    {   
        bool userExist = false;
        GameObject db = GameObject.Find("DB");
        main main = db.GetComponent<main>();

        userExist = main.ChechIfUserExist(username.text.ToString());

        if(userExist == true)
        {
            userCreated.text = "User allready exists";
        }
        else
        {
            main.CreateUser(name.text.ToString(), username.text.ToString(), password.text.ToString());
            userCreated.text = "User created successfully";
        }
        
    }
}
