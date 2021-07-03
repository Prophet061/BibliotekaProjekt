﻿using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BibliotekaProjekt
{
    class Database
    {
        private string host = "sql.serwer2077031.home.pl";
        private string user = "33700168_programowanie";
        private string password = "c6cBK3cQ";
        private string name = "33700168_programowanie";

        private MySqlConnection sqlCon = new MySqlConnection();
        private MySqlCommand sqlCmd = new MySqlCommand();
        private DataTable sqlDt = new DataTable();
        private MySqlDataReader sqlRead;

        public DataTable Query(string query, IDictionary Parameters)
        {

            try
            {
                sqlCon.ConnectionString = "server=" + host + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + name;
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = query;
                foreach (DictionaryEntry data in Parameters)
                {
                    sqlCmd.Parameters.AddWithValue("@" + data.Key, data.Value);
                }

                sqlRead = sqlCmd.ExecuteReader();
                sqlDt.Load(sqlRead);
                sqlRead.Close();

                return sqlDt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        ~Database()
        {
            //MessageBox.Show("close");
            //sqlCon.Close();
        }

    }
}
