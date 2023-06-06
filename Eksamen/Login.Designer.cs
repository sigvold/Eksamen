namespace Eksamen
{
    partial class Login
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
            this.txtBrukernavn = new System.Windows.Forms.TextBox();
            this.txtPassord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblBrukernavn = new System.Windows.Forms.Label();
            this.lblPassord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBrukernavn
            // 
            this.txtBrukernavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtBrukernavn.Location = new System.Drawing.Point(165, 126);
            this.txtBrukernavn.Multiline = true;
            this.txtBrukernavn.Name = "txtBrukernavn";
            this.txtBrukernavn.Size = new System.Drawing.Size(188, 26);
            this.txtBrukernavn.TabIndex = 0;
            // 
            // txtPassord
            // 
            this.txtPassord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPassord.Location = new System.Drawing.Point(165, 182);
            this.txtPassord.Multiline = true;
            this.txtPassord.Name = "txtPassord";
            this.txtPassord.PasswordChar = '*';
            this.txtPassord.Size = new System.Drawing.Size(188, 26);
            this.txtPassord.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(205, 214);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblBrukernavn
            // 
            this.lblBrukernavn.AutoSize = true;
            this.lblBrukernavn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrukernavn.Location = new System.Drawing.Point(161, 99);
            this.lblBrukernavn.Name = "lblBrukernavn";
            this.lblBrukernavn.Size = new System.Drawing.Size(122, 24);
            this.lblBrukernavn.TabIndex = 3;
            this.lblBrukernavn.Text = "Brukernavn:";
            // 
            // lblPassord
            // 
            this.lblPassord.AutoSize = true;
            this.lblPassord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassord.Location = new System.Drawing.Point(161, 155);
            this.lblPassord.Name = "lblPassord";
            this.lblPassord.Size = new System.Drawing.Size(91, 24);
            this.lblPassord.TabIndex = 4;
            this.lblPassord.Text = "Passord:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 517);
            this.Controls.Add(this.lblPassord);
            this.Controls.Add(this.lblBrukernavn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassord);
            this.Controls.Add(this.txtBrukernavn);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrukernavn;
        private System.Windows.Forms.TextBox txtPassord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblBrukernavn;
        private System.Windows.Forms.Label lblPassord;
    }
}

