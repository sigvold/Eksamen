namespace Eksamen
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtBrukernavn = new System.Windows.Forms.TextBox();
            this.lblBrukernavn = new System.Windows.Forms.Label();
            this.lblPassord = new System.Windows.Forms.Label();
            this.txtPassord = new System.Windows.Forms.TextBox();
            this.lblStilling = new System.Windows.Forms.Label();
            this.txtStilling = new System.Windows.Forms.TextBox();
            this.lblprosjekt = new System.Windows.Forms.Label();
            this.txtProsjekt = new System.Windows.Forms.TextBox();
            this.lblTelefonnr = new System.Windows.Forms.Label();
            this.txtTelefonnr = new System.Windows.Forms.TextBox();
            this.lbladresse = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblIsadmin = new System.Windows.Forms.Label();
            this.txtIsadmin = new System.Windows.Forms.TextBox();
            this.lblPostnr = new System.Windows.Forms.Label();
            this.txtPostnr = new System.Windows.Forms.TextBox();
            this.btnOppdater = new System.Windows.Forms.Button();
            this.btnLeggtil = new System.Windows.Forms.Button();
            this.btnSlett = new System.Windows.Forms.Button();
            this.btnLoggut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(160, 81);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(787, 306);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.DataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 1;
            // 
            // txtBrukernavn
            // 
            this.txtBrukernavn.Location = new System.Drawing.Point(30, 97);
            this.txtBrukernavn.Name = "txtBrukernavn";
            this.txtBrukernavn.Size = new System.Drawing.Size(100, 20);
            this.txtBrukernavn.TabIndex = 2;
            // 
            // lblBrukernavn
            // 
            this.lblBrukernavn.AutoSize = true;
            this.lblBrukernavn.Location = new System.Drawing.Point(27, 81);
            this.lblBrukernavn.Name = "lblBrukernavn";
            this.lblBrukernavn.Size = new System.Drawing.Size(65, 13);
            this.lblBrukernavn.TabIndex = 3;
            this.lblBrukernavn.Text = "Brukernavn:";
            // 
            // lblPassord
            // 
            this.lblPassord.AutoSize = true;
            this.lblPassord.Location = new System.Drawing.Point(27, 120);
            this.lblPassord.Name = "lblPassord";
            this.lblPassord.Size = new System.Drawing.Size(48, 13);
            this.lblPassord.TabIndex = 5;
            this.lblPassord.Text = "Passord:";
            // 
            // txtPassord
            // 
            this.txtPassord.Location = new System.Drawing.Point(30, 136);
            this.txtPassord.Name = "txtPassord";
            this.txtPassord.PasswordChar = '*';
            this.txtPassord.Size = new System.Drawing.Size(100, 20);
            this.txtPassord.TabIndex = 4;
            // 
            // lblStilling
            // 
            this.lblStilling.AutoSize = true;
            this.lblStilling.Location = new System.Drawing.Point(27, 158);
            this.lblStilling.Name = "lblStilling";
            this.lblStilling.Size = new System.Drawing.Size(40, 13);
            this.lblStilling.TabIndex = 7;
            this.lblStilling.Text = "Stilling:";
            // 
            // txtStilling
            // 
            this.txtStilling.Location = new System.Drawing.Point(30, 174);
            this.txtStilling.Name = "txtStilling";
            this.txtStilling.Size = new System.Drawing.Size(100, 20);
            this.txtStilling.TabIndex = 6;
            // 
            // lblprosjekt
            // 
            this.lblprosjekt.AutoSize = true;
            this.lblprosjekt.Location = new System.Drawing.Point(27, 197);
            this.lblprosjekt.Name = "lblprosjekt";
            this.lblprosjekt.Size = new System.Drawing.Size(48, 13);
            this.lblprosjekt.TabIndex = 9;
            this.lblprosjekt.Text = "Prosjekt:";
            // 
            // txtProsjekt
            // 
            this.txtProsjekt.Location = new System.Drawing.Point(30, 213);
            this.txtProsjekt.Name = "txtProsjekt";
            this.txtProsjekt.Size = new System.Drawing.Size(100, 20);
            this.txtProsjekt.TabIndex = 8;
            // 
            // lblTelefonnr
            // 
            this.lblTelefonnr.AutoSize = true;
            this.lblTelefonnr.Location = new System.Drawing.Point(27, 235);
            this.lblTelefonnr.Name = "lblTelefonnr";
            this.lblTelefonnr.Size = new System.Drawing.Size(55, 13);
            this.lblTelefonnr.TabIndex = 11;
            this.lblTelefonnr.Text = "Telefonnr:";
            // 
            // txtTelefonnr
            // 
            this.txtTelefonnr.Location = new System.Drawing.Point(30, 251);
            this.txtTelefonnr.Name = "txtTelefonnr";
            this.txtTelefonnr.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonnr.TabIndex = 10;
            // 
            // lbladresse
            // 
            this.lbladresse.AutoSize = true;
            this.lbladresse.Location = new System.Drawing.Point(27, 274);
            this.lbladresse.Name = "lbladresse";
            this.lbladresse.Size = new System.Drawing.Size(48, 13);
            this.lbladresse.TabIndex = 13;
            this.lbladresse.Text = "Adresse:";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(30, 290);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtAdresse.TabIndex = 12;
            // 
            // lblIsadmin
            // 
            this.lblIsadmin.AutoSize = true;
            this.lblIsadmin.Location = new System.Drawing.Point(27, 351);
            this.lblIsadmin.Name = "lblIsadmin";
            this.lblIsadmin.Size = new System.Drawing.Size(47, 13);
            this.lblIsadmin.TabIndex = 17;
            this.lblIsadmin.Text = "IsAdmin:";
            // 
            // txtIsadmin
            // 
            this.txtIsadmin.Location = new System.Drawing.Point(30, 367);
            this.txtIsadmin.Name = "txtIsadmin";
            this.txtIsadmin.Size = new System.Drawing.Size(100, 20);
            this.txtIsadmin.TabIndex = 16;
            // 
            // lblPostnr
            // 
            this.lblPostnr.AutoSize = true;
            this.lblPostnr.Location = new System.Drawing.Point(27, 312);
            this.lblPostnr.Name = "lblPostnr";
            this.lblPostnr.Size = new System.Drawing.Size(40, 13);
            this.lblPostnr.TabIndex = 15;
            this.lblPostnr.Text = "Postnr:";
            // 
            // txtPostnr
            // 
            this.txtPostnr.Location = new System.Drawing.Point(30, 328);
            this.txtPostnr.Name = "txtPostnr";
            this.txtPostnr.Size = new System.Drawing.Size(100, 20);
            this.txtPostnr.TabIndex = 14;
            // 
            // btnOppdater
            // 
            this.btnOppdater.Location = new System.Drawing.Point(30, 412);
            this.btnOppdater.Name = "btnOppdater";
            this.btnOppdater.Size = new System.Drawing.Size(75, 23);
            this.btnOppdater.TabIndex = 18;
            this.btnOppdater.Text = "Oppdater";
            this.btnOppdater.UseVisualStyleBackColor = true;
            this.btnOppdater.Click += new System.EventHandler(this.btnoppdater_Click);
            // 
            // btnLeggtil
            // 
            this.btnLeggtil.Location = new System.Drawing.Point(134, 412);
            this.btnLeggtil.Name = "btnLeggtil";
            this.btnLeggtil.Size = new System.Drawing.Size(75, 23);
            this.btnLeggtil.TabIndex = 19;
            this.btnLeggtil.Text = "Legg til";
            this.btnLeggtil.UseVisualStyleBackColor = true;
            this.btnLeggtil.Click += new System.EventHandler(this.btnleggtil_Click);
            // 
            // btnSlett
            // 
            this.btnSlett.Location = new System.Drawing.Point(236, 412);
            this.btnSlett.Name = "btnSlett";
            this.btnSlett.Size = new System.Drawing.Size(75, 23);
            this.btnSlett.TabIndex = 20;
            this.btnSlett.Text = "Slett";
            this.btnSlett.UseVisualStyleBackColor = true;
            this.btnSlett.Click += new System.EventHandler(this.btnslett_Click);
            // 
            // btnLoggut
            // 
            this.btnLoggut.Location = new System.Drawing.Point(30, 472);
            this.btnLoggut.Name = "btnLoggut";
            this.btnLoggut.Size = new System.Drawing.Size(75, 23);
            this.btnLoggut.TabIndex = 21;
            this.btnLoggut.Text = "Logg ut";
            this.btnLoggut.UseVisualStyleBackColor = true;
            this.btnLoggut.Click += new System.EventHandler(this.btnloggut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 549);
            this.Controls.Add(this.btnLoggut);
            this.Controls.Add(this.btnSlett);
            this.Controls.Add(this.btnLeggtil);
            this.Controls.Add(this.btnOppdater);
            this.Controls.Add(this.lblIsadmin);
            this.Controls.Add(this.txtIsadmin);
            this.Controls.Add(this.lblPostnr);
            this.Controls.Add(this.txtPostnr);
            this.Controls.Add(this.lbladresse);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblTelefonnr);
            this.Controls.Add(this.txtTelefonnr);
            this.Controls.Add(this.lblprosjekt);
            this.Controls.Add(this.txtProsjekt);
            this.Controls.Add(this.lblStilling);
            this.Controls.Add(this.txtStilling);
            this.Controls.Add(this.lblPassord);
            this.Controls.Add(this.txtPassord);
            this.Controls.Add(this.lblBrukernavn);
            this.Controls.Add(this.txtBrukernavn);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.DataGridView);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtBrukernavn;
        private System.Windows.Forms.Label lblBrukernavn;
        private System.Windows.Forms.Label lblPassord;
        private System.Windows.Forms.TextBox txtPassord;
        private System.Windows.Forms.Label lblStilling;
        private System.Windows.Forms.TextBox txtStilling;
        private System.Windows.Forms.Label lblprosjekt;
        private System.Windows.Forms.TextBox txtProsjekt;
        private System.Windows.Forms.Label lblTelefonnr;
        private System.Windows.Forms.TextBox txtTelefonnr;
        private System.Windows.Forms.Label lbladresse;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblIsadmin;
        private System.Windows.Forms.TextBox txtIsadmin;
        private System.Windows.Forms.Label lblPostnr;
        private System.Windows.Forms.TextBox txtPostnr;
        private System.Windows.Forms.Button btnOppdater;
        private System.Windows.Forms.Button btnLeggtil;
        private System.Windows.Forms.Button btnSlett;
        private System.Windows.Forms.Button btnLoggut;
    }
}