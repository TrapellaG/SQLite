using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Data;
using Mono.Data.Sqlite;


public class main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string connection = "URI=file:" + Application.persistentDataPath + "/My_Database";

        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        //IDbCommand dbcmd;
        IDataReader reader;

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

        IDbCommand cmnd_read = dbcon.CreateCommand();
        string query = "SELECT * FROM my_table";
        cmnd_read.CommandText = query;
        reader = cmnd_read.ExecuteReader(); while (reader.Read())
        {
            Debug.Log("id: " + reader[0].ToString());
            Debug.Log("val: " + reader[1].ToString());
        }
        dbcon.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
