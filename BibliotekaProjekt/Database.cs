using System;
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
        private MySqlDataReader sqlReader;

        public DataTable Query(string query, IDictionary Parameters)
        {

            try
            {
                sqlCon.ConnectionString = "Server=" + host + "; Database=" + name + "; Uid=" + user + ";" + "Pwd=" + password + ";";
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = query;
                foreach (DictionaryEntry data in Parameters)
                {
                    sqlCmd.Parameters.AddWithValue("@" + data.Key, data.Value);
                }

                sqlReader = sqlCmd.ExecuteReader();
                sqlDt.Load(sqlReader);
                sqlReader.Close();
                sqlCon.Close();

                return sqlDt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public MySqlDataReader Query2(string query, IDictionary Parameters)
        {

            try
            {
                sqlCon.ConnectionString = "Server=" + host + "; Database=" + name + "; Uid=" + user + ";" + "Pwd=" + password + "; convert zero datetime=True";
                sqlCon.Open();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = query;
                foreach (DictionaryEntry data in Parameters)
                {
                    sqlCmd.Parameters.AddWithValue("@" + data.Key, data.Value);
                }

                sqlReader = sqlCmd.ExecuteReader();
                return sqlReader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        public int Exec(string query, IDictionary Parameters)
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
                int rows_affected = sqlCmd.ExecuteNonQuery();
                sqlCon.Close();


                return rows_affected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return 0;
        }

        public void Close()
        {
            try
            {
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ~Database()
        {
        }

    }
}
