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
    public partial class Czytelnicy : Form
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


        public Czytelnicy()
        {
            InitializeComponent();
        }

        private void upLoadData()
        {
            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "SELECT * FROM Czytelnicytbl";
            sqlRead = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRead);
            sqlRead.Close();
            sqlCon.Close();
            widokCzytelnicy.DataSource = sqlDt;
        }




        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StronaGlowna stronaglowna = new StronaGlowna();
            stronaglowna.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(widokCzytelnicy.SelectedRows[0].Cells[0].Value);

            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            sqlCon.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = "Update Czytelnicytbl set Imie=@Imie, Nazwisko=@Nazwisko, NumerTelefonu=@NumerTelefonu where idCzytelnik=@idCzytelnik";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@idCzytelnik", i);
                sqlCmd.Parameters.AddWithValue("@Imie", czytelnikImie.Text);
                sqlCmd.Parameters.AddWithValue("@Nazwisko", czytelnikNazwisko.Text);
                sqlCmd.Parameters.AddWithValue("@NumerTelefonu", czytelnikTel.Text);

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
                sqlQuery = "insert into Czytelnicytbl (Imie, Nazwisko, NumerTelefonu)" +
                "values('" + czytelnikImie.Text + "', '" + czytelnikNazwisko.Text + "', '" +
                 czytelnikTel.Text + "')";

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

        private void button1_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(widokCzytelnicy.SelectedRows[0].Cells[0].Value);

            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;



            sqlCon.Open();
            sqlQuery = "delete from Czytelnicytbl where idCzytelnik=@idCzytelnik";

            sqlCmd = new MySqlCommand(sqlQuery, sqlCon);
            sqlCmd.Parameters.AddWithValue("@idCzytelnik", i);

            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            foreach (DataGridViewRow item in this.widokCzytelnicy.SelectedRows)
            {
                widokCzytelnicy.Rows.RemoveAt(item.Index);
            }



            upLoadData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Czytelnicy_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        private void widokCzytelnicy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                czytelnikImie.Text = widokCzytelnicy.SelectedRows[0].Cells[1].Value.ToString();
                czytelnikNazwisko.Text = widokCzytelnicy.SelectedRows[0].Cells[2].Value.ToString();
                czytelnikTel.Text = widokCzytelnicy.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
