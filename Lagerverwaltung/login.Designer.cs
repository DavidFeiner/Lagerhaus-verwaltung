namespace Lagerverwaltung
{
    partial class login
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtB_username = new System.Windows.Forms.TextBox();
            this.txtB_password = new System.Windows.Forms.TextBox();
            this.lbl_headline = new System.Windows.Forms.Label();
            this.bttn_accept = new System.Windows.Forms.Button();
            this.bttn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(38, 112);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(78, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Benutzername:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(38, 146);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Passwort:";
            // 
            // txtB_username
            // 
            this.txtB_username.Location = new System.Drawing.Point(163, 112);
            this.txtB_username.Name = "txtB_username";
            this.txtB_username.Size = new System.Drawing.Size(100, 20);
            this.txtB_username.TabIndex = 2;
            // 
            // txtB_password
            // 
            this.txtB_password.Location = new System.Drawing.Point(163, 143);
            this.txtB_password.Name = "txtB_password";
            this.txtB_password.PasswordChar = '*';
            this.txtB_password.Size = new System.Drawing.Size(100, 20);
            this.txtB_password.TabIndex = 3;
            // 
            // lbl_headline
            // 
            this.lbl_headline.AutoSize = true;
            this.lbl_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headline.Location = new System.Drawing.Point(67, 29);
            this.lbl_headline.Name = "lbl_headline";
            this.lbl_headline.Size = new System.Drawing.Size(164, 24);
            this.lbl_headline.TabIndex = 4;
            this.lbl_headline.Text = "Lagerverwaltung";
            // 
            // bttn_accept
            // 
            this.bttn_accept.Location = new System.Drawing.Point(188, 251);
            this.bttn_accept.Name = "bttn_accept";
            this.bttn_accept.Size = new System.Drawing.Size(75, 23);
            this.bttn_accept.TabIndex = 5;
            this.bttn_accept.Text = "anmelden";
            this.bttn_accept.UseVisualStyleBackColor = true;
            this.bttn_accept.Click += new System.EventHandler(this.bttn_accept_Click);
            // 
            // bttn_close
            // 
            this.bttn_close.Location = new System.Drawing.Point(41, 251);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(75, 23);
            this.bttn_close.TabIndex = 6;
            this.bttn_close.Text = "schließen";
            this.bttn_close.UseVisualStyleBackColor = true;
            this.bttn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 318);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.bttn_accept);
            this.Controls.Add(this.lbl_headline);
            this.Controls.Add(this.txtB_password);
            this.Controls.Add(this.txtB_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtB_username;
        private System.Windows.Forms.TextBox txtB_password;
        private System.Windows.Forms.Label lbl_headline;
        private System.Windows.Forms.Button bttn_accept;
        private System.Windows.Forms.Button bttn_close;
    }
}