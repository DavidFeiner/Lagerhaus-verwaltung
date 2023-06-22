namespace Lagerverwaltung
{
    partial class RegisterAdmin
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
            this.lbl_admin = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password1 = new System.Windows.Forms.Label();
            this.lbl_password2 = new System.Windows.Forms.Label();
            this.txtB_username = new System.Windows.Forms.TextBox();
            this.txtB_password = new System.Windows.Forms.TextBox();
            this.txtB_password2 = new System.Windows.Forms.TextBox();
            this.bttn_accept = new System.Windows.Forms.Button();
            this.bttn_exit = new System.Windows.Forms.Button();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbL_name = new System.Windows.Forms.Label();
            this.txtB_name = new System.Windows.Forms.TextBox();
            this.txtB_surname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Location = new System.Drawing.Point(128, 42);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(39, 13);
            this.lbl_admin.TabIndex = 0;
            this.lbl_admin.Text = "Admin:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(24, 134);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(78, 13);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Benutzername:";
            // 
            // lbl_password1
            // 
            this.lbl_password1.AutoSize = true;
            this.lbl_password1.Location = new System.Drawing.Point(24, 155);
            this.lbl_password1.Name = "lbl_password1";
            this.lbl_password1.Size = new System.Drawing.Size(53, 13);
            this.lbl_password1.TabIndex = 2;
            this.lbl_password1.Text = "Passwort:";
            // 
            // lbl_password2
            // 
            this.lbl_password2.AutoSize = true;
            this.lbl_password2.Location = new System.Drawing.Point(25, 179);
            this.lbl_password2.Name = "lbl_password2";
            this.lbl_password2.Size = new System.Drawing.Size(53, 13);
            this.lbl_password2.TabIndex = 3;
            this.lbl_password2.Text = "Passwort:";
            // 
            // txtB_username
            // 
            this.txtB_username.Location = new System.Drawing.Point(167, 127);
            this.txtB_username.Name = "txtB_username";
            this.txtB_username.Size = new System.Drawing.Size(100, 20);
            this.txtB_username.TabIndex = 4;
            // 
            // txtB_password
            // 
            this.txtB_password.Location = new System.Drawing.Point(167, 148);
            this.txtB_password.Name = "txtB_password";
            this.txtB_password.Size = new System.Drawing.Size(100, 20);
            this.txtB_password.TabIndex = 5;
            // 
            // txtB_password2
            // 
            this.txtB_password2.Location = new System.Drawing.Point(167, 172);
            this.txtB_password2.Name = "txtB_password2";
            this.txtB_password2.Size = new System.Drawing.Size(100, 20);
            this.txtB_password2.TabIndex = 6;
            // 
            // bttn_accept
            // 
            this.bttn_accept.Location = new System.Drawing.Point(192, 319);
            this.bttn_accept.Name = "bttn_accept";
            this.bttn_accept.Size = new System.Drawing.Size(75, 23);
            this.bttn_accept.TabIndex = 7;
            this.bttn_accept.Text = "speichern";
            this.bttn_accept.UseVisualStyleBackColor = true;
            this.bttn_accept.Click += new System.EventHandler(this.bttn_accept_Click);
            // 
            // bttn_exit
            // 
            this.bttn_exit.Location = new System.Drawing.Point(28, 319);
            this.bttn_exit.Name = "bttn_exit";
            this.bttn_exit.Size = new System.Drawing.Size(75, 23);
            this.bttn_exit.TabIndex = 8;
            this.bttn_exit.Text = "schließen";
            this.bttn_exit.UseVisualStyleBackColor = true;
            this.bttn_exit.Click += new System.EventHandler(this.bttn_exit_Click);
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(25, 117);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(62, 13);
            this.lbl_surname.TabIndex = 9;
            this.lbl_surname.Text = "Nachname:";
            // 
            // lbL_name
            // 
            this.lbL_name.AutoSize = true;
            this.lbL_name.Location = new System.Drawing.Point(24, 98);
            this.lbL_name.Name = "lbL_name";
            this.lbL_name.Size = new System.Drawing.Size(52, 13);
            this.lbL_name.TabIndex = 10;
            this.lbL_name.Text = "Vorname:";
            // 
            // txtB_name
            // 
            this.txtB_name.Location = new System.Drawing.Point(167, 80);
            this.txtB_name.Name = "txtB_name";
            this.txtB_name.Size = new System.Drawing.Size(100, 20);
            this.txtB_name.TabIndex = 11;
            // 
            // txtB_surname
            // 
            this.txtB_surname.Location = new System.Drawing.Point(167, 106);
            this.txtB_surname.Name = "txtB_surname";
            this.txtB_surname.Size = new System.Drawing.Size(100, 20);
            this.txtB_surname.TabIndex = 12;
            // 
            // RegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 372);
            this.Controls.Add(this.txtB_surname);
            this.Controls.Add(this.txtB_name);
            this.Controls.Add(this.lbL_name);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.bttn_exit);
            this.Controls.Add(this.bttn_accept);
            this.Controls.Add(this.txtB_password2);
            this.Controls.Add(this.txtB_password);
            this.Controls.Add(this.txtB_username);
            this.Controls.Add(this.lbl_password2);
            this.Controls.Add(this.lbl_password1);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_admin);
            this.Name = "RegisterAdmin";
            this.Text = "RegisterAdmin";
            this.Load += new System.EventHandler(this.RegisterAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password1;
        private System.Windows.Forms.Label lbl_password2;
        private System.Windows.Forms.TextBox txtB_username;
        private System.Windows.Forms.TextBox txtB_password;
        private System.Windows.Forms.TextBox txtB_password2;
        private System.Windows.Forms.Button bttn_accept;
        private System.Windows.Forms.Button bttn_exit;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbL_name;
        private System.Windows.Forms.TextBox txtB_name;
        private System.Windows.Forms.TextBox txtB_surname;
    }
}