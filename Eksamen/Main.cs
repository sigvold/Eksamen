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

        private string InnloggetBrukernavn;
        private int IsAdmin;
        private int UserID;
        public Main(MySqlDataReader mdr)
        {
            //this.userId = userId; IKKJE SKRIVE NOE OM LBL ELLER TXT OSV

            InnloggetBrukernavn = mdr.GetString("Brukernavn");
            IsAdmin = mdr.GetInt32("IsAdmin");
            UserID = mdr.GetInt32("id");
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
            if (IsAdmin == 1)
            {
                try
                {
                    string selectQuery = $"SELECT * FROM eksamen_db.Brukere WHERE IsAdmin = 0 OR id = {UserID}";
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
            else
            {
                try
                {
                    string selectQuery = $"SELECT * FROM eksamen_db.Brukere WHERE id = {UserID}";
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

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Print();
            lblUser.Text = "Velkommen: " + InnloggetBrukernavn; // Setter teksten til etiketten
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbrukernavn.Text = DataGridView.CurrentRow.Cells[0].Value.ToString();

        }
    }
}
