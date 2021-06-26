using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace BibliotekaProjekt
{
    public partial class Bibliotekarze : Form
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


        public Bibliotekarze()
        {
            InitializeComponent();
        }

        private void upLoadData()
        {
            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "SELECT * FROM Bibliotekarzetbl";
            sqlRead = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRead);
            sqlRead.Close();
            sqlCon.Close();
            widokBibliotekarze.DataSource = sqlDt;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bibliotekarze_Load(object sender, EventArgs e)
        {
            upLoadData();
           
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            try
            {
                sqlCon.Open();
                sqlQuery = "insert into Bibliotekarzetbl (Imie, Nazwisko, Hasło, Telefon)" + 
                "values('" + bibliotekarzImie.Text + "', '" + bibliotekarzNazwisko.Text + "', '" +
                bibliotekarzHaslo.Text + "','" + bibliotekarzTel.Text + "')";

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
            i = Convert.ToInt32(widokBibliotekarze.SelectedRows[0].Cells[0].Value);

            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            sqlCon.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = "Update Bibliotekarzetbl set Imie=@Imie, Nazwisko=@Nazwisko, Hasło=@Hasło, Telefon=@Telefon where idBibliotekarz=@idBibliotekarz";
                
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@idBibliotekarz", i);
                sqlCmd.Parameters.AddWithValue("@Imie", bibliotekarzImie.Text);
                sqlCmd.Parameters.AddWithValue("@Nazwisko", bibliotekarzNazwisko.Text);
                sqlCmd.Parameters.AddWithValue("@Hasło", bibliotekarzHaslo.Text);
                sqlCmd.Parameters.AddWithValue("@Telefon", bibliotekarzTel.Text);

                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                upLoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void widokBibliotekarze_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bibliotekarzImie.Text = widokBibliotekarze.SelectedRows[0].Cells[1].Value.ToString();
                bibliotekarzNazwisko.Text = widokBibliotekarze.SelectedRows[0].Cells[2].Value.ToString();
                bibliotekarzHaslo.Text = widokBibliotekarze.SelectedRows[0].Cells[3].Value.ToString();
                bibliotekarzTel.Text = widokBibliotekarze.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        

        private void button1_Click(object sender, EventArgs e)
        {



            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            sqlCon.Open();

            sqlCmd.Connection = sqlCon;

            sqlCmd.CommandText = "delete from Bibliotekarzetbl where idBibliotekarz=@idBibliotekarz";
            sqlCmd = new MySqlCommand(sqlQuery, sqlCon);
            sqlCon.Close();
            foreach (DataGridViewRow item in this.widokBibliotekarze.SelectedRows)
            {
                widokBibliotekarze.Rows.RemoveAt(item.Index);
            }




            //sqlCon.Open();
            //sqlCmd.Connection = sqlCon;
            //string deleteQuery = "delete from Bibliotekarzetbl where id = " + int.Parse
            //(bibliotekarzImie.Text);



            //upLoadData();



            //foreach (DataGridViewCell oneCell in widokBibliotekarze.SelectedCells)
            //{
            //    if (oneCell.Selected == false) continue;

            //    string i = widokBibliotekarze.SelectedRows[0].Cells[1].Value.ToString();
            //    widokBibliotekarze.Rows.RemoveAt(oneCell.RowIndex);
            //    string query = "DELETE FROM Bibliotekarzetbl WHERE idBibliotekarze='" + i + "'";


            //    {
            //        using (var cmd = new MySqlCommand(query, sqlCon))
            //        {
            //            sqlCon.Open();
            //            sqlCmd.ExecuteNonQuery();
            //            sqlCon.Close();
            //        }
            //    }
            //}


            //try
            //{
            //    sqlCon.Open();
            //    MySqlCommand sqlCmd = new MySqlCommand();
            //    sqlCmd.Connection = sqlCon;

            //    sqlCmd.CommandText = "delete from Bibliotekarzetbl where idBibliotekarz";
            //    sqlCmd = new MySqlCommand(sqlQuery, sqlCon);

            //    foreach (DataGridViewRow item in this.widokBibliotekarze.SelectedRows)
            //    {
            //        widokBibliotekarze.Rows.RemoveAt(item.Index);
            //    }

            //    sqlCmd.ExecuteNonQuery();
            //    sqlCon.Close();
            //    upLoadData();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}





        }
    }
}

