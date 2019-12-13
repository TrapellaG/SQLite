using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.UI;


public class main : MonoBehaviour
{
    public ArrayList items;

    // Start is called before the first frame update
    void Start()
    {
        

        //        CREATE TABLE IF NOT EXISTS "items"(
        //    "id_item"   INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
        //    "item"  TEXT NOT NULL,
        //    "price" INTEGER NOT NULL,
        //    "img"   TEXT,
        //    "desc"  TEXT
        //);


        //        CREATE TABLE IF NOT EXISTS"players"(
        //    "id_player" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
        //    "name"  TEXT NOT NULL,
        //    "user"  TEXT NOT NULL,
        //    "pass"  TEXT NOT NULL,
        //    "money" INTEGER NOT NULL DEFAULT 0,
        //    "img"   TEXT
        //);



        //        CREATE TABLE IF NOT EXISTS "inventory"(
        //    "id_inventory"  INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
        //    "id_player" INTEGER NOT NULL,
        //    "id_item"   INTEGER NOT NULL,
        //    "quantity"  INTEGER NOT NULL DEFAULT 0
        //);




        //dbcmd = dbcon.CreateCommand();
        //string q_createTable =
        //  "CREATE TABLE IF NOT EXISTS my_table (id INTEGER PRIMARY KEY, val INTEGER )";

        //dbcmd.CommandText = q_createTable;
        //reader = dbcmd.ExecuteReader();

        //IDbCommand cmnd = dbcon.CreateCommand();
        //cmnd.CommandText = "INSERT INTO my_table (id, val) VALUES (0, 5)";
        //cmnd.ExecuteNonQuery();

        


    }

    public bool ChechIfUserExist(string username)
    {
        bool exist = false;

        string connection = "URI=file:" + Application.persistentDataPath + "/My_Database";

        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        //IDbCommand dbcmd;
        IDataReader reader;

        IDbCommand cmnd_read = dbcon.CreateCommand();
        string query = "SELECT user FROM players WHERE user = '"+username+"'";
        cmnd_read.CommandText = query;

        reader = cmnd_read.ExecuteReader();

        if(reader != null)
        {
            exist = true;
        }
        else
        {
            exist = false;
        }

        dbcon.Close();

        return exist;
    }

    public void CreateUser(string name, string username, string password)
    {

        Debug.Log("ok");
        string connection = "URI=file:" + Application.persistentDataPath + "/My_Database";

        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        //IDbCommand dbcmd;
        IDataReader reader;

        IDbCommand cmnd_read = dbcon.CreateCommand();
        string query = "INSERT INTO players (name, user, pass, money) VALUES ('"+name+"', '"+username+"', '"+password+"', 1000)";
        cmnd_read.CommandText = query;
        reader = cmnd_read.ExecuteReader();
        dbcon.Close();

        Debug.Log(query);
    }

    public void SetItems()
    {
        items = new ArrayList();

        string connection = "URI=file:" + Application.persistentDataPath + "/My_Database";

        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        //IDbCommand dbcmd;
        IDataReader reader;

        IDbCommand cmnd_read = dbcon.CreateCommand();
        string query = "SELECT * FROM items";
        cmnd_read.CommandText = query;

        reader = cmnd_read.ExecuteReader(); while (reader.Read())
        {
            items.Add(new Item(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[4].ToString()));
        }
        dbcon.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
