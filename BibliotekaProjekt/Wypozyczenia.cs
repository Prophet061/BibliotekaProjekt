using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BibliotekaProjekt
{
    public partial class Wypozyczenia : Form
    {
        int i;

        MySqlConnection sqlCon = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRead;

        DataSet DS = new DataSet();

        String server = "sql.serwer2077031.home.pl";
        String username = "33700168_programowanie";
        String password = "c6cBK3cQ";
        String database = "33700168_programowanie";
        public static string OPTION = "Convert Zero Datetime=True";




        public Wypozyczenia()
        {
            InitializeComponent();
        }

        private void upLoadData()
        {
            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database + ";" + OPTION + ";";

            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "SELECT * FROM Wypozyczenia";
            sqlRead = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRead);
            sqlRead.Close();
            sqlCon.Close();
            widokWypozyczenia.DataSource = sqlDt;
        }

        private void Wypozyczenia_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            StronaGlowna main = new StronaGlowna();
            main.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(widokWypozyczenia.SelectedRows[0].Cells[0].Value);

            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;



            sqlCon.Open();
            sqlQuery = "delete from Wypozyczenia where idWypozyczenia=@idWypozyczenia";

            sqlCmd = new MySqlCommand(sqlQuery, sqlCon);
            sqlCmd.Parameters.AddWithValue("@idWypozyczenia", i);

            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            foreach (DataGridViewRow item in this.widokWypozyczenia.SelectedRows)
            {
                widokWypozyczenia.Rows.RemoveAt(item.Index);
            }



            upLoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DateTime theDate = DateTime.Now;
            //theDate.ToString("yyyy-MM-dd");
            //string strDate = dataWyp.Value.ToString("yyyy/MM/dd");
            //string strDate1 = dataOdb.Value.ToString("yyyy/MM/dd");
            i = Convert.ToInt32(widokWypozyczenia.SelectedRows[0].Cells[0].Value);

            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            sqlCon.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = "Update Wypozyczenia set idKsiazka=@idKsiazka, idCzytelnik=@idCzytelnik, osobaWypozyczajaca=@osobaWypozyczajaca, osobaOdbierajaca=@osobaOdbierajaca, dataWypozyczenia=@dataWypozyczenia, dataOdbioru=@dataOdbioru where idWypozyczenia=@idWypozyczenia";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@idWypozyczenia", i);
                sqlCmd.Parameters.AddWithValue("@idKsiazka", idKsiazki.Text);
                sqlCmd.Parameters.AddWithValue("@idCzytelnik", idCzytelnika.Text);
                sqlCmd.Parameters.AddWithValue("@osobaWypozyczajaca", osobaWyp.Text);
                sqlCmd.Parameters.AddWithValue("@osobaOdbierajaca", osobaOdb.Text);
                sqlCmd.Parameters.AddWithValue("@dataWypozyczenia", dataWyp.Text);
                sqlCmd.Parameters.AddWithValue("@dataOdbioru", dataOdb.Text);

                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                upLoadData();

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            try
            {
                sqlCon.Open();
                sqlQuery = "insert into Wypozyczenia (idKsiazka, idCzytelnik, osobaWypozyczajaca, osobaOdbierajaca, dataWypozyczenia, dataOdbioru)" +
                "values('" + idKsiazki.Text + "', '" + idCzytelnika.Text + "', '" +
                osobaWyp.Text + "','" + osobaOdb.Text + "','" + this.dataWyp.Text + "','" + this.dataOdb.Text + "')";

                sqlCmd = new MySqlCommand(sqlQuery, sqlCon);
                sqlRead = sqlCmd.ExecuteReader();

                sqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            upLoadData();
        }

        private void widokWypozyczenia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
 


