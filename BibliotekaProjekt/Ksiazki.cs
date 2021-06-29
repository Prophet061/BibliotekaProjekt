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
    public partial class Ksiazki : Form
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


        public Ksiazki()
        {
            InitializeComponent();
        }

        private void upLoadData()
        {
            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "SELECT * FROM Ksiazkitbl";
            sqlRead = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRead);
            sqlRead.Close();
            sqlCon.Close();
            widokKsiazki.DataSource = sqlDt;
        }





        private void button4_Click(object sender, EventArgs e)
        {
            StronaGlowna stronaglowna = new StronaGlowna();
            stronaglowna.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ksiazkiTytul.Text = widokKsiazki.SelectedRows[0].Cells[1].Value.ToString();
                ksiazkiAutor.Text = widokKsiazki.SelectedRows[0].Cells[2].Value.ToString();
                ksiazkiGatunek.Text = widokKsiazki.SelectedRows[0].Cells[3].Value.ToString();
                ksiazkiIsbn.Text = widokKsiazki.SelectedRows[0].Cells[4].Value.ToString();
                ksiazkiRok.Text = widokKsiazki.SelectedRows[0].Cells[5].Value.ToString();
                ksiazkiIlosc.Text = widokKsiazki.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Ksiazki_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            try
            {
                sqlCon.Open();
                sqlQuery = "insert into Ksiazkitbl (Tytul, Autor, Gatunek, ISBN, RokWydania, Ilosc)" +
                "values('" + ksiazkiTytul.Text + "', '" + ksiazkiAutor.Text + "', '" +
                ksiazkiGatunek.Text + "','" + ksiazkiIsbn.Text + "','" + ksiazkiRok.Text + "','" + ksiazkiIlosc.Text + "')";

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

        private void button3_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(widokKsiazki.SelectedRows[0].Cells[0].Value);

            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            sqlCon.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = "Update Ksiazkitbl set Tytul=@Tytul, Autor=@Autor, Gatunek=@Gatunek, ISBN=@ISBN, RokWydania=@RokWydania, Ilosc=@Ilosc where idKsiazki=@idKsiazki";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@idKsiazki", i);
                sqlCmd.Parameters.AddWithValue("@Tytul", ksiazkiTytul.Text);
                sqlCmd.Parameters.AddWithValue("@Autor", ksiazkiAutor.Text);
                sqlCmd.Parameters.AddWithValue("@Gatunek", ksiazkiGatunek.Text);
                sqlCmd.Parameters.AddWithValue("@ISBN", ksiazkiIsbn.Text);
                sqlCmd.Parameters.AddWithValue("@RokWydania", ksiazkiRok.Text);
                sqlCmd.Parameters.AddWithValue("@Ilosc", ksiazkiIlosc.Text);

                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                upLoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(widokKsiazki.SelectedRows[0].Cells[0].Value);

            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;



            sqlCon.Open();
            sqlQuery = "delete from Ksiazkitbl where idKsiazki=@idKsiazki";

            sqlCmd = new MySqlCommand(sqlQuery, sqlCon);
            sqlCmd.Parameters.AddWithValue("@idKsiazki", i);

            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            foreach (DataGridViewRow item in this.widokKsiazki.SelectedRows)
            {
                widokKsiazki.Rows.RemoveAt(item.Index);
            }



            upLoadData();

        }

        private void widokKsiazki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
