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
            this.btnAvslutt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(158, 72);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(809, 306);
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
            this.txtBrukernavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrukernavn.Location = new System.Drawing.Point(30, 72);
            this.txtBrukernavn.Name = "txtBrukernavn";
            this.txtBrukernavn.Size = new System.Drawing.Size(100, 22);
            this.txtBrukernavn.TabIndex = 2;
            // 
            // lblBrukernavn
            // 
            this.lblBrukernavn.AutoSize = true;
            this.lblBrukernavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblBrukernavn.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBrukernavn.Location = new System.Drawing.Point(26, 49);
            this.lblBrukernavn.Name = "lblBrukernavn";
            this.lblBrukernavn.Size = new System.Drawing.Size(99, 20);
            this.lblBrukernavn.TabIndex = 3;
            this.lblBrukernavn.Text = "Brukernavn:";
            // 
            // lblPassord
            // 
            this.lblPassord.AutoSize = true;
            this.lblPassord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPassord.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassord.Location = new System.Drawing.Point(27, 95);
            this.lblPassord.Name = "lblPassord";
            this.lblPassord.Size = new System.Drawing.Size(76, 20);
            this.lblPassord.TabIndex = 5;
            this.lblPassord.Text = "Passord:";
            // 
            // txtPassord
            // 
            this.txtPassord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassord.Location = new System.Drawing.Point(30, 118);
            this.txtPassord.Name = "txtPassord";
            this.txtPassord.PasswordChar = '*';
            this.txtPassord.Size = new System.Drawing.Size(100, 22);
            this.txtPassord.TabIndex = 4;
            // 
            // lblStilling
            // 
            this.lblStilling.AutoSize = true;
            this.lblStilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblStilling.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStilling.Location = new System.Drawing.Point(27, 143);
            this.lblStilling.Name = "lblStilling";
            this.lblStilling.Size = new System.Drawing.Size(64, 20);
            this.lblStilling.TabIndex = 7;
            this.lblStilling.Text = "Stilling:";
            // 
            // txtStilling
            // 
            this.txtStilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStilling.Location = new System.Drawing.Point(30, 166);
            this.txtStilling.Name = "txtStilling";
            this.txtStilling.Size = new System.Drawing.Size(100, 22);
            this.txtStilling.TabIndex = 6;
            // 
            // lblprosjekt
            // 
            this.lblprosjekt.AutoSize = true;
            this.lblprosjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblprosjekt.ForeColor = System.Drawing.SystemColors.Control;
            this.lblprosjekt.Location = new System.Drawing.Point(26, 191);
            this.lblprosjekt.Name = "lblprosjekt";
            this.lblprosjekt.Size = new System.Drawing.Size(75, 20);
            this.lblprosjekt.TabIndex = 9;
            this.lblprosjekt.Text = "Prosjekt:";
            // 
            // txtProsjekt
            // 
            this.txtProsjekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProsjekt.Location = new System.Drawing.Point(30, 214);
            this.txtProsjekt.Name = "txtProsjekt";
            this.txtProsjekt.Size = new System.Drawing.Size(100, 22);
            this.txtProsjekt.TabIndex = 8;
            // 
            // lblTelefonnr
            // 
            this.lblTelefonnr.AutoSize = true;
            this.lblTelefonnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTelefonnr.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefonnr.Location = new System.Drawing.Point(27, 239);
            this.lblTelefonnr.Name = "lblTelefonnr";
            this.lblTelefonnr.Size = new System.Drawing.Size(84, 20);
            this.lblTelefonnr.TabIndex = 11;
            this.lblTelefonnr.Text = "Telefonnr:";
            // 
            // txtTelefonnr
            // 
            this.txtTelefonnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonnr.Location = new System.Drawing.Point(30, 262);
            this.txtTelefonnr.Name = "txtTelefonnr";
            this.txtTelefonnr.Size = new System.Drawing.Size(100, 22);
            this.txtTelefonnr.TabIndex = 10;
            // 
            // lbladresse
            // 
            this.lbladresse.AutoSize = true;
            this.lbladresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbladresse.ForeColor = System.Drawing.SystemColors.Control;
            this.lbladresse.Location = new System.Drawing.Point(27, 287);
            this.lbladresse.Name = "lbladresse";
            this.lbladresse.Size = new System.Drawing.Size(76, 20);
            this.lbladresse.TabIndex = 13;
            this.lbladresse.Text = "Adresse:";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(30, 310);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 22);
            this.txtAdresse.TabIndex = 12;
            // 
            // lblIsadmin
            // 
            this.lblIsadmin.AutoSize = true;
            this.lblIsadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIsadmin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIsadmin.Location = new System.Drawing.Point(26, 383);
            this.lblIsadmin.Name = "lblIsadmin";
            this.lblIsadmin.Size = new System.Drawing.Size(74, 20);
            this.lblIsadmin.TabIndex = 17;
            this.lblIsadmin.Text = "IsAdmin:";
            // 
            // txtIsadmin
            // 
            this.txtIsadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsadmin.Location = new System.Drawing.Point(30, 406);
            this.txtIsadmin.Name = "txtIsadmin";
            this.txtIsadmin.Size = new System.Drawing.Size(100, 22);
            this.txtIsadmin.TabIndex = 16;
            // 
            // lblPostnr
            // 
            this.lblPostnr.AutoSize = true;
            this.lblPostnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPostnr.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPostnr.Location = new System.Drawing.Point(28, 335);
            this.lblPostnr.Name = "lblPostnr";
            this.lblPostnr.Size = new System.Drawing.Size(63, 20);
            this.lblPostnr.TabIndex = 15;
            this.lblPostnr.Text = "Postnr:";
            // 
            // txtPostnr
            // 
            this.txtPostnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostnr.Location = new System.Drawing.Point(30, 358);
            this.txtPostnr.Name = "txtPostnr";
            this.txtPostnr.Size = new System.Drawing.Size(100, 22);
            this.txtPostnr.TabIndex = 14;
            // 
            // btnOppdater
            // 
            this.btnOppdater.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnOppdater.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOppdater.Location = new System.Drawing.Point(158, 399);
            this.btnOppdater.Name = "btnOppdater";
            this.btnOppdater.Size = new System.Drawing.Size(79, 35);
            this.btnOppdater.TabIndex = 18;
            this.btnOppdater.Text = "Oppdater";
            this.btnOppdater.UseVisualStyleBackColor = true;
            this.btnOppdater.Click += new System.EventHandler(this.btnoppdater_Click);
            // 
            // btnLeggtil
            // 
            this.btnLeggtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLeggtil.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLeggtil.Location = new System.Drawing.Point(260, 399);
            this.btnLeggtil.Name = "btnLeggtil";
            this.btnLeggtil.Size = new System.Drawing.Size(79, 35);
            this.btnLeggtil.TabIndex = 19;
            this.btnLeggtil.Text = "Legg til";
            this.btnLeggtil.UseVisualStyleBackColor = true;
            this.btnLeggtil.Click += new System.EventHandler(this.btnleggtil_Click);
            // 
            // btnSlett
            // 
            this.btnSlett.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSlett.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSlett.Location = new System.Drawing.Point(361, 399);
            this.btnSlett.Name = "btnSlett";
            this.btnSlett.Size = new System.Drawing.Size(79, 35);
            this.btnSlett.TabIndex = 20;
            this.btnSlett.Text = "Slett";
            this.btnSlett.UseVisualStyleBackColor = true;
            this.btnSlett.Click += new System.EventHandler(this.btnslett_Click);
            // 
            // btnLoggut
            // 
            this.btnLoggut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnLoggut.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoggut.Location = new System.Drawing.Point(30, 479);
            this.btnLoggut.Name = "btnLoggut";
            this.btnLoggut.Size = new System.Drawing.Size(79, 35);
            this.btnLoggut.TabIndex = 21;
            this.btnLoggut.Text = "Logg ut";
            this.btnLoggut.UseVisualStyleBackColor = true;
            this.btnLoggut.Click += new System.EventHandler(this.btnloggut_Click);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAvslutt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAvslutt.Location = new System.Drawing.Point(158, 479);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(79, 35);
            this.btnAvslutt.TabIndex = 22;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.UseVisualStyleBackColor = true;
            this.btnAvslutt.Click += new System.EventHandler(this.btnAvslutt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(999, 548);
            this.Controls.Add(this.btnAvslutt);
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
        private System.Windows.Forms.Button btnAvslutt;
    }
}