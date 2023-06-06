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
    public partial class Main : Form
    {
        MySqlConnection connection = new MySqlConnection("server=192.168.1.141;port=3306;user id=sigve;password=jd_es;database=eksamen_db");
        MySqlCommand command = new MySqlCommand();
        //private int userId; // Holder brukerens ID
        private string InnloggetBrukernavn;
        public Main(MySqlDataReader mdr)
        {
            //this.userId = userId;

            InnloggetBrukernavn = mdr.GetString("Brukernavn");
            //Console.WriteLine(InnloggetBrukernavn);
            InitializeComponent();
            //int userId = mdr.GetInt32("id");
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

        public void executeQuery(String query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Querry Executed!");
                }
                else
                {
                    MessageBox.Show("Querry Not Executed!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void Print()
        {
            try
            {
                string selectQuery = "SELECT * FROM eksamen_db.Brukere";
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                adapter.Fill(dataTable);
                DataGridView.DataSource = dataTable;

                closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Print();

            Label lblWelcome = new Label(); // Oppretter en ny label
            lblWelcome.Text = "Velkommen:" + InnloggetBrukernavn.ToString(); // Setter teksten til etiketten
            lblWelcome.Location = new Point(10, 10); // Plasserer etiketten på skjermen
            this.Controls.Add(lblWelcome); // Legger etiketten til skjermkontrollene
        }
    }
}
