﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlBDM.models
{
    class ConnectionBD
    {
        public MySqlConnection connManager = new MySqlConnection();
        string server = "127.0.0.1;";
        string database = "sakila;";
        string user = "root;";
        string pass = "root;";

        public MySqlConnection DataSource()
        {
            connManager = new MySqlConnection
                ($"server={server} database={database} Uid={user} password={pass}");
            return connManager;
        }

        public void ConnectOpened() 
        {
            //DataSource();
            connManager.Open();
        }

        public void ConnectClosed()
        {
            //DataSource();
            connManager.Close();
        }

        public bool ExecuteQuery(string sql)
        {
            bool result = false;
            try 
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
                cmd.ExecuteNonQuery();
                result = true;

            }
            catch (Exception w) 
            {
                Console.WriteLine("Hay un ERROR: : " + w.Message);
                ConnectClosed();
            }
            finally 
            {
                ConnectClosed();
            }
            return result;
        }
    }
}
