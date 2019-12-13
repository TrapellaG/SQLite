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
    
    public void SendParamsToDB()
    {
      
        bool userExist = false;
        GameObject db = GameObject.Find("DB");
        main main = db.GetComponent<main>();

        userExist = main.ChechIfUserExist(username.text.ToString());

        if(userExist == true)
        {
            Debug.Log(userExist);
            //usuario ya existe
        }
        else
        {
            Debug.Log(userExist);
            main.CreateUser(name.text.ToString(), username.text.ToString(), password.text.ToString());
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
