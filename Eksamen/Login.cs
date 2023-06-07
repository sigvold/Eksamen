using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksamen
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("server=192.168.1.141;port=3306;user id=sigve;password=jd_es;database=eksamen_db");

        public Login()
        {
            InitializeComponent();
        }

        // Funksjon som åpner koblingen til databasen
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Funksjon som lukker koblingen til databasen
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                //Åpner opp database koblingen
                openConnection();
                //Definerer Queryen som skal kjøre på databasen
                string SelectQuery = "SELECT * FROM Brukere WHERE Brukernavn = @Username AND Passord = @Password";
                //Lager det om til en cmd siden vi skal legge til noen variabler for @Username og @Passord
                MySqlCommand cmd = new MySqlCommand(SelectQuery, connection);
                //Legger til variablene til i SelectQueryen med informasjonen fra tekstboksene
                cmd.Parameters.AddWithValue("@Username", txtBrukernavn.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassord.Text);
               
                // Oppretter en datareader variabel som returnerer hva den fikk ut fra Queryen fra databasen
                MySqlDataReader mdr = cmd.ExecuteReader();

                // Sjekker om det var gyldig treff i databasen med passord og brukernavn
                if (mdr.Read())
                {
                    //Skjuler denne formsen
                    this.Hide();
                    //Oppretter en variabel for hovud formen og viser den
                    Main frm2 = new Main(mdr);
                    frm2.ShowDialog();
                }
                // lukker datareaderen
                mdr.Close();
            }
            catch (Exception ex)
            {
                //Skriver ut i Konsolen om det er en feil
                Console.WriteLine("login failed" + ex);
            }
            //Lukker database koblingen
            closeConnection();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            //Avslutten applikasjonen
            Application.Exit();
        }
    }
}
