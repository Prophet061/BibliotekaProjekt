using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace BibliotekaProjekt
{
    public partial class Bibliotekarze : Form
    {

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
            sqlCon.ConnectionString = "server=" + server + ";" + "user id=" + username + ";" + "password=" + password + ";" + "database=" + database;

            sqlCon.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlCon;

                sqlCmd.CommandText = "Update Bibliotekarzetbl set Imie=@Imie, Nazwisko=@Nazwisko, Hasło=@Hasło, Telefon=@Telefon where idBibliotekarz=@idBibliotekarz";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Imie", bibliotekarzImie.Text);
                sqlCmd.Parameters.AddWithValue("@Nazwisko", bibliotekarzNazwisko.Text);
                sqlCmd.Parameters.AddWithValue("@Hasło", bibliotekarzHaslo.Text);
                sqlCmd.Parameters.AddWithValue("@Telefon", bibliotekarzTel.Text);
                sqlCmd.Parameters.AddWithValue("@idBibliotekarz", widokBibliotekarze.SelectedCells);

                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                upLoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

