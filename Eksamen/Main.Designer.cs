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
            this.txtbrukernavn = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtpassord = new System.Windows.Forms.TextBox();
            this.lblstilling = new System.Windows.Forms.Label();
            this.txtstilling = new System.Windows.Forms.TextBox();
            this.lblprosjekt = new System.Windows.Forms.Label();
            this.txtprosjekt = new System.Windows.Forms.TextBox();
            this.lbltelefonnr = new System.Windows.Forms.Label();
            this.txttelefonnr = new System.Windows.Forms.TextBox();
            this.lbladresse = new System.Windows.Forms.Label();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.lblisadmin = new System.Windows.Forms.Label();
            this.txtisadmin = new System.Windows.Forms.TextBox();
            this.lblpostnr = new System.Windows.Forms.Label();
            this.txtpostnr = new System.Windows.Forms.TextBox();
            this.btnoppdater = new System.Windows.Forms.Button();
            this.btnleggtil = new System.Windows.Forms.Button();
            this.btnslett = new System.Windows.Forms.Button();
            this.btnloggut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(160, 81);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(787, 306);
            this.DataGridView.TabIndex = 0;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 1;
            // 
            // txtbrukernavn
            // 
            this.txtbrukernavn.Location = new System.Drawing.Point(30, 97);
            this.txtbrukernavn.Name = "txtbrukernavn";
            this.txtbrukernavn.Size = new System.Drawing.Size(100, 20);
            this.txtbrukernavn.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(27, 81);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Brukernavn:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(48, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Passord:";
            // 
            // txtpassord
            // 
            this.txtpassord.Location = new System.Drawing.Point(30, 136);
            this.txtpassord.Name = "txtpassord";
            this.txtpassord.PasswordChar = '*';
            this.txtpassord.Size = new System.Drawing.Size(100, 20);
            this.txtpassord.TabIndex = 4;
            // 
            // lblstilling
            // 
            this.lblstilling.AutoSize = true;
            this.lblstilling.Location = new System.Drawing.Point(27, 158);
            this.lblstilling.Name = "lblstilling";
            this.lblstilling.Size = new System.Drawing.Size(40, 13);
            this.lblstilling.TabIndex = 7;
            this.lblstilling.Text = "Stilling:";
            // 
            // txtstilling
            // 
            this.txtstilling.Location = new System.Drawing.Point(30, 174);
            this.txtstilling.Name = "txtstilling";
            this.txtstilling.Size = new System.Drawing.Size(100, 20);
            this.txtstilling.TabIndex = 6;
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
            // txtprosjekt
            // 
            this.txtprosjekt.Location = new System.Drawing.Point(30, 213);
            this.txtprosjekt.Name = "txtprosjekt";
            this.txtprosjekt.Size = new System.Drawing.Size(100, 20);
            this.txtprosjekt.TabIndex = 8;
            // 
            // lbltelefonnr
            // 
            this.lbltelefonnr.AutoSize = true;
            this.lbltelefonnr.Location = new System.Drawing.Point(27, 235);
            this.lbltelefonnr.Name = "lbltelefonnr";
            this.lbltelefonnr.Size = new System.Drawing.Size(55, 13);
            this.lbltelefonnr.TabIndex = 11;
            this.lbltelefonnr.Text = "Telefonnr:";
            // 
            // txttelefonnr
            // 
            this.txttelefonnr.Location = new System.Drawing.Point(30, 251);
            this.txttelefonnr.Name = "txttelefonnr";
            this.txttelefonnr.Size = new System.Drawing.Size(100, 20);
            this.txttelefonnr.TabIndex = 10;
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
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(30, 290);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(100, 20);
            this.txtadresse.TabIndex = 12;
            // 
            // lblisadmin
            // 
            this.lblisadmin.AutoSize = true;
            this.lblisadmin.Location = new System.Drawing.Point(27, 351);
            this.lblisadmin.Name = "lblisadmin";
            this.lblisadmin.Size = new System.Drawing.Size(47, 13);
            this.lblisadmin.TabIndex = 17;
            this.lblisadmin.Text = "IsAdmin:";
            // 
            // txtisadmin
            // 
            this.txtisadmin.Location = new System.Drawing.Point(30, 367);
            this.txtisadmin.Name = "txtisadmin";
            this.txtisadmin.Size = new System.Drawing.Size(100, 20);
            this.txtisadmin.TabIndex = 16;
            // 
            // lblpostnr
            // 
            this.lblpostnr.AutoSize = true;
            this.lblpostnr.Location = new System.Drawing.Point(27, 312);
            this.lblpostnr.Name = "lblpostnr";
            this.lblpostnr.Size = new System.Drawing.Size(40, 13);
            this.lblpostnr.TabIndex = 15;
            this.lblpostnr.Text = "Postnr:";
            // 
            // txtpostnr
            // 
            this.txtpostnr.Location = new System.Drawing.Point(30, 328);
            this.txtpostnr.Name = "txtpostnr";
            this.txtpostnr.Size = new System.Drawing.Size(100, 20);
            this.txtpostnr.TabIndex = 14;
            // 
            // btnoppdater
            // 
            this.btnoppdater.Location = new System.Drawing.Point(30, 412);
            this.btnoppdater.Name = "btnoppdater";
            this.btnoppdater.Size = new System.Drawing.Size(75, 23);
            this.btnoppdater.TabIndex = 18;
            this.btnoppdater.Text = "Oppdater";
            this.btnoppdater.UseVisualStyleBackColor = true;
            this.btnoppdater.Click += new System.EventHandler(this.btnoppdater_Click);
            // 
            // btnleggtil
            // 
            this.btnleggtil.Location = new System.Drawing.Point(134, 412);
            this.btnleggtil.Name = "btnleggtil";
            this.btnleggtil.Size = new System.Drawing.Size(75, 23);
            this.btnleggtil.TabIndex = 19;
            this.btnleggtil.Text = "Legg til";
            this.btnleggtil.UseVisualStyleBackColor = true;
            this.btnleggtil.Click += new System.EventHandler(this.btnleggtil_Click);
            // 
            // btnslett
            // 
            this.btnslett.Location = new System.Drawing.Point(236, 412);
            this.btnslett.Name = "btnslett";
            this.btnslett.Size = new System.Drawing.Size(75, 23);
            this.btnslett.TabIndex = 20;
            this.btnslett.Text = "Slett";
            this.btnslett.UseVisualStyleBackColor = true;
            this.btnslett.Click += new System.EventHandler(this.btnslett_Click);
            // 
            // btnloggut
            // 
            this.btnloggut.Location = new System.Drawing.Point(30, 472);
            this.btnloggut.Name = "btnloggut";
            this.btnloggut.Size = new System.Drawing.Size(75, 23);
            this.btnloggut.TabIndex = 21;
            this.btnloggut.Text = "Logg ut";
            this.btnloggut.UseVisualStyleBackColor = true;
            this.btnloggut.Click += new System.EventHandler(this.btnloggut_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 549);
            this.Controls.Add(this.btnloggut);
            this.Controls.Add(this.btnslett);
            this.Controls.Add(this.btnleggtil);
            this.Controls.Add(this.btnoppdater);
            this.Controls.Add(this.lblisadmin);
            this.Controls.Add(this.txtisadmin);
            this.Controls.Add(this.lblpostnr);
            this.Controls.Add(this.txtpostnr);
            this.Controls.Add(this.lbladresse);
            this.Controls.Add(this.txtadresse);
            this.Controls.Add(this.lbltelefonnr);
            this.Controls.Add(this.txttelefonnr);
            this.Controls.Add(this.lblprosjekt);
            this.Controls.Add(this.txtprosjekt);
            this.Controls.Add(this.lblstilling);
            this.Controls.Add(this.txtstilling);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtpassord);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtbrukernavn);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.DataGridView);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtbrukernavn;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtpassord;
        private System.Windows.Forms.Label lblstilling;
        private System.Windows.Forms.TextBox txtstilling;
        private System.Windows.Forms.Label lblprosjekt;
        private System.Windows.Forms.TextBox txtprosjekt;
        private System.Windows.Forms.Label lbltelefonnr;
        private System.Windows.Forms.TextBox txttelefonnr;
        private System.Windows.Forms.Label lbladresse;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.Label lblisadmin;
        private System.Windows.Forms.TextBox txtisadmin;
        private System.Windows.Forms.Label lblpostnr;
        private System.Windows.Forms.TextBox txtpostnr;
        private System.Windows.Forms.Button btnoppdater;
        private System.Windows.Forms.Button btnleggtil;
        private System.Windows.Forms.Button btnslett;
        private System.Windows.Forms.Button btnloggut;
    }
}