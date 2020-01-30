using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System;
using Mono.Data.Sqlite;
using UnityEngine.UI;


public class main : MonoBehaviour
{
    public ArrayList items;

    public void UpdateMoney(int userMoney, string username)
    {
        string connection = "URI=file:" + Application.persistentDataPath + "/My_Database";

        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        //IDbCommand dbcmd;
        IDataReader reader;

        IDbCommand cmnd_read = dbcon.CreateCommand();
        string query = "UPDATE players SET money = '" + userMoney + "' WHERE user = '" + username + "'";
        cmnd_read.CommandType = CommandType.Text;
        cmnd_read.CommandText = query;
        Debug.Log(query);

        reader = cmnd_read.ExecuteReader();

        dbcon.Close();

    }

    public int CheckEnoughtMoney(string username)
    {
        int userMoney = 0;

        string connection = "URI=file:" + Application.persistentDataPath + "/My_Database";

        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        //IDbCommand dbcmd;
        IDataReader reader;

        IDbCommand cmnd_read = dbcon.CreateCommand();
        string query = "SELECT money FROM players WHERE user = '" + username + "'";
        cmnd_read.CommandType = CommandType.Text;
        cmnd_read.CommandText = query;

        userMoney = Convert.ToInt32(cmnd_read.ExecuteScalar());

        reader = cmnd_read.ExecuteReader();

        dbcon.Close();

        return userMoney;

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
        string query = "SELECT count(id_player) FROM players WHERE user = '" + username+"'";
        cmnd_read.CommandType = CommandType.Text;
        cmnd_read.CommandText = query;

        int RowCount = 0;
        RowCount = Convert.ToInt32(cmnd_read.ExecuteScalar());

        reader = cmnd_read.ExecuteReader();

        if (RowCount > 0)
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

    public bool CheckLogin(string username, string password)
    {
        bool ok = false;

        string connection = "URI=file:" + Application.persistentDataPath + "/My_Database";

        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        //IDbCommand dbcmd;
        IDataReader reader;

        IDbCommand cmnd_read = dbcon.CreateCommand();

        string query = "SELECT count(id_player) FROM players WHERE user = '" + username + "' AND pass = '" + password + "'";
        cmnd_read.CommandType = CommandType.Text;
        cmnd_read.CommandText = query;

        int RowCount = 0;
        RowCount = Convert.ToInt32(cmnd_read.ExecuteScalar());

        reader = cmnd_read.ExecuteReader();

        if (RowCount > 0)
        {
            ok = true;
        }
        else
        {
            ok = false;
        }

        dbcon.Close();

        return ok;
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

}
