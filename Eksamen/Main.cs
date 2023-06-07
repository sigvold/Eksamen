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
        //Definerer noen lokale variabler som kommer til å bli brukt ofte 
        private string InnloggetBrukernavn;
        private int IsAdmin;
        private int UserID;
        private int CurrentSelectedID;

        //Funksjon som kjører i starten av opprettelsen av forms-en
        public Main(MySqlDataReader mdr)
        {
            //Henter mdr fra login siden
            //Redefinerer variablene ut fra mdr fra login siden
            InnloggetBrukernavn = mdr.GetString("Brukernavn");
            IsAdmin = mdr.GetInt32("IsAdmin");
            UserID = mdr.GetInt32("id");
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

        //Funksjon som bare kjører string Query's vi sender
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

        //Funksjon som kjører når DataGridViewen skal oppdateres (Her kan vi endre informasjon)
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Sjekker om kolonnen som genereres heter "Passord"
            if (this.DataGridView.Columns[e.ColumnIndex].Name == "Passord")
            {
                //Skjekker om verdien er ikke blank
                if (e.Value != null)
                {
                    //Setter displayen av kolonnen til "********" slik vi ikke ser andre sine passord
                    e.Value = "*********";
                    e.FormattingApplied = true;
                }
            }
        }

        //Setter innhold til alle tekstboks inputene til blank
        private void ClearAllTextBoxs()
        {
            txtBrukernavn.Text = "";
            txtPassord.Text = "";
            txtStilling.Text = "";
            txtProsjekt.Text = "";
            txtTelefonnr.Text = "";
            txtAdresse.Text = "";
            txtPostnr.Text = "";
            txtIsadmin.Text = "";
        }

        //Skjuler knapper om brukeren ikke er admin
        private void HideIfNotAdmin()
        {
            if (IsAdmin == 0)
            {
                lblIsadmin.Visible = false;
                txtIsadmin.Visible = false;

                btnLeggtil.Visible = false;
                btnSlett.Visible = false;
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {
            //Oppdaterer gridviewen
            Print();
            //Legger til navnet til personen som er innlogget til labelen
            lblUser.Text = "Velkommen: " + InnloggetBrukernavn;
            //Skjuler knapper om brukeren ikke er admin
            HideIfNotAdmin();
        }

        // Henter ut informasjon fra gridviewen og setter det inn i tekstboksene
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentSelectedID = (int)DataGridView.CurrentRow.Cells[0].Value;
            txtBrukernavn.Text = DataGridView.CurrentRow.Cells[1].Value.ToString();
            txtPassord.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
            txtStilling.Text = DataGridView.CurrentRow.Cells[3].Value.ToString();
            txtProsjekt.Text = DataGridView.CurrentRow.Cells[4].Value.ToString();
            txtTelefonnr.Text = DataGridView.CurrentRow.Cells[5].Value.ToString();
            txtAdresse.Text = DataGridView.CurrentRow.Cells[6].Value.ToString();
            txtPostnr.Text = DataGridView.CurrentRow.Cells[7].Value.ToString();
            txtIsadmin.Text = DataGridView.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnoppdater_Click(object sender, EventArgs e)
        {
            //Konverterer string tekstboks inputene til int siden databasen aksepterer bare INT på disse 3
            int TelefonnrINT = Convert.ToInt32(txtTelefonnr.Text);
            int PostnrINT = Convert.ToInt32(txtPostnr.Text);
            int IsAdminINT = Convert.ToInt32(txtIsadmin.Text);

            //Definerer Queryen som skal kjøre på databasen
            string updateQuery = $"UPDATE eksamen_db.Brukere SET Brukernavn='{txtBrukernavn.Text}', Passord='{txtPassord.Text}', Stilling='{txtStilling.Text}', Prosjekt='{txtProsjekt.Text}', Telefonnr='{TelefonnrINT}', Adresse='{txtAdresse.Text}', Postnr='{PostnrINT}', IsAdmin='{IsAdminINT}' WHERE id='{CurrentSelectedID}'";
            //Kjører Queryen ved bruk at "executeQuery" kommandoen
            executeQuery(updateQuery);

            //Skjekker at viss den dataen som blir oppdatert er på den person som er innlogget så passer vi på å skifte en lokal variabel her som passer på å vise admin rettigheter om personen er admin, derfor om de skifter admin tilgang på seg selv til ikke admin så mister de rettighetene
            if (UserID == CurrentSelectedID)
            {
 
                IsAdmin = IsAdminINT;
            }
            //Skjuler knapper om brukeren ikke er admin
            HideIfNotAdmin();

            //Oppdaterer gridviewen
            Print();

            //Setter innhold til alle tekstboks inputene til blank
            ClearAllTextBoxs();

        }

        private void btnleggtil_Click(object sender, EventArgs e)
        {
            //Konverterer string tekstboks inputene til int siden databasen aksepterer bare INT på disse 3
            int TelefonnrINT = Convert.ToInt32(txtTelefonnr.Text);
            int PostnrINT = Convert.ToInt32(txtPostnr.Text);
            int IsAdminINT = Convert.ToInt32(txtIsadmin.Text);

            //Definerer Queryen som skal kjøre på databasen
            string insertQuery = $"INSERT INTO eksamen_db.Brukere (id, Brukernavn, Passord, Stilling, Prosjekt, Telefonnr, Adresse, Postnr, IsAdmin)VALUES('{0}','{txtBrukernavn.Text}', '{txtPassord.Text}', '{txtStilling.Text}', '{txtProsjekt.Text}', '{TelefonnrINT}', '{txtAdresse.Text}', '{PostnrINT}', '{IsAdminINT}')";
            //Kjører Queryen ved bruk at "executeQuery" kommandoen
            executeQuery(insertQuery);

            //Oppdaterer gridviewen
            Print();

            //Setter innhold til alle tekstboks inputene til blank
            ClearAllTextBoxs();
        }

        private void btnslett_Click(object sender, EventArgs e)
        {
            string deletQuery = $"DELETE FROM eksamen_db.Brukere WHERE id = {CurrentSelectedID}";
            executeQuery(deletQuery);

            //Hvis innlogget bruker sletter seg selv så logger vi de ut
            if (UserID == CurrentSelectedID)
            {
                //Lukker denne formsen og åpner den andre
                this.Close();
                Login loginForm = new Login();
                loginForm.Closed += (s, args) => this.Close();
                loginForm.Show();
            }

            //Oppdaterer gridviewen
            Print();

            //Setter innhold til alle tekstboks inputene til blank
            ClearAllTextBoxs();
        }

        private void btnloggut_Click(object sender, EventArgs e)
        {
            //Lukker denne formsen og åpner den andre
            this.Close();
            Login loginForm = new Login();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {
            //Avslutten applikasjonen
            Application.Exit();
        }
    }
}
