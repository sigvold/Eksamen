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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cs = $"SERVER=192.168.1.141;DATABASE=eksamen_db;UID=sigve;PASSWORD=jd_es";

            var con = new MySqlConnection(cs);

            try
            {
                con.Open();
                string SelectQuery = "SELECT * FROM Brukere WHERE Brukernavn = @Username AND Passord = @Password";
                MySqlCommand cmd = new MySqlCommand(SelectQuery, con);

                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
               
                MySqlDataReader mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                    Console.WriteLine("SUCCESS");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("login failed");
            }

            con.Close();

        }
    }
}
