using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.WellKnownTypes.Field.Types;

namespace Eksamen
{
    public partial class Main : Form
    {
        MySqlConnection connection = new MySqlConnection("server=192.168.1.141;port=3306;user id=sigve;password=jd_es;database=eksamen_db");
        MySqlCommand command = new MySqlCommand();

        private string InnloggetBrukernavn;
        private int IsAdmin;
        private int UserID;
        private int CurrentSelectedID;
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
            openConnection();
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

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.DataGridView.Columns[e.ColumnIndex].Name == "Passord")
            {
                if (e.Value != null)
                {
                    e.Value = "*********";
                    e.FormattingApplied = true;
                }
            }
        }


        private void ClearAllTextBoxs()
        {
            txtbrukernavn.Text = "";
            txtpassord.Text = "";
            txtstilling.Text = "";
            txtprosjekt.Text = "";
            txttelefonnr.Text = "";
            txtadresse.Text = "";
            txtpostnr.Text = "";
            txtisadmin.Text = "";
        }

        private void HideIfNotAdmin()
        {
            if (IsAdmin == 0)
            {
                lblisadmin.Visible = false;
                txtisadmin.Visible = false;

                btnleggtil.Visible = false;
                btnslett.Visible = false;
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Print();
            lblUser.Text = "Velkommen: " + InnloggetBrukernavn; // Setter teksten til etiketten
            HideIfNotAdmin();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentSelectedID = (int)DataGridView.CurrentRow.Cells[0].Value;
            txtbrukernavn.Text = DataGridView.CurrentRow.Cells[1].Value.ToString();
            txtpassord.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
            txtstilling.Text = DataGridView.CurrentRow.Cells[3].Value.ToString();
            txtprosjekt.Text = DataGridView.CurrentRow.Cells[4].Value.ToString();
            txttelefonnr.Text = DataGridView.CurrentRow.Cells[5].Value.ToString();
            txtadresse.Text = DataGridView.CurrentRow.Cells[6].Value.ToString();
            txtpostnr.Text = DataGridView.CurrentRow.Cells[7].Value.ToString();
            txtisadmin.Text = DataGridView.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnoppdater_Click(object sender, EventArgs e)
        {
            
            int TelefonnrINT = Convert.ToInt32(txttelefonnr.Text);
            int PostnrINT = Convert.ToInt32(txtpostnr.Text);
            int IsAdminINT = Convert.ToInt32(txtisadmin.Text);


            string updateQuery = $"UPDATE eksamen_db.Brukere SET Brukernavn='{txtbrukernavn.Text}', Passord='{txtpassord.Text}', Stilling='{txtstilling.Text}', Prosjekt='{txtprosjekt.Text}', Telefonnr='{TelefonnrINT}', Adresse='{txtadresse.Text}', Postnr='{PostnrINT}', IsAdmin='{IsAdminINT}' WHERE id='{CurrentSelectedID}'";
            executeQuery(updateQuery);

            if (UserID == CurrentSelectedID)
            {
                Console.WriteLine("Changed Self Data");
                IsAdmin = IsAdminINT;
            }

            HideIfNotAdmin();

            Print();

            //Make this a function
            ClearAllTextBoxs();

        }

        private void btnleggtil_Click(object sender, EventArgs e)
        {
            int TelefonnrINT = Convert.ToInt32(txttelefonnr.Text);
            int PostnrINT = Convert.ToInt32(txtpostnr.Text);
            int IsAdminINT = Convert.ToInt32(txtisadmin.Text);


            string insertQuery = $"INSERT INTO eksamen_db.Brukere (id, Brukernavn, Passord, Stilling, Prosjekt, Telefonnr, Adresse, Postnr, IsAdmin)VALUES('{0}','{txtbrukernavn.Text}', '{txtpassord.Text}', '{txtstilling.Text}', '{txtprosjekt.Text}', '{TelefonnrINT}', '{txtadresse.Text}', '{PostnrINT}', '{IsAdminINT}')";
            executeQuery(insertQuery);

            Print();

            ClearAllTextBoxs();
        }

        private void btnslett_Click(object sender, EventArgs e)
        {
            string deletQuery = $"DELETE FROM eksamen_db.Brukere WHERE id = {CurrentSelectedID}";
            executeQuery(deletQuery);

            if (UserID == CurrentSelectedID)
            {
                //Make this a function
                this.Close();
                Login loginForm = new Login();
                loginForm.Closed += (s, args) => this.Close();
                loginForm.Show();
            }

            Print();

            ClearAllTextBoxs();
        }

        private void btnloggut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
