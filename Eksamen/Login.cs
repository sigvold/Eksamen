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

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

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
                openConnection();
                string SelectQuery = "SELECT * FROM Brukere WHERE Brukernavn = @Username AND Passord = @Password";
                MySqlCommand cmd = new MySqlCommand(SelectQuery, connection);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
               
                MySqlDataReader mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    Console.WriteLine("SUCCESS");
                   // int userId = mdr.GetInt32("id");
                    this.Hide();
                    Main frm2 = new Main(mdr);
                    frm2.ShowDialog();
                }
                mdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("login failed");
            }

            closeConnection();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
