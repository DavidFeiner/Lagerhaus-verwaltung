namespace Lagerverwaltung
{
    partial class addEmployee
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
            this.lbl_employee = new System.Windows.Forms.Label();
            this.lbl_storageHeadline = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_password2 = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txtB_name = new System.Windows.Forms.TextBox();
            this.txtB_surname = new System.Windows.Forms.TextBox();
            this.txtB_username = new System.Windows.Forms.TextBox();
            this.txtB_password = new System.Windows.Forms.TextBox();
            this.txtB_password2 = new System.Windows.Forms.TextBox();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_back = new System.Windows.Forms.Button();
            this.bttn_seeAll = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee.Location = new System.Drawing.Point(181, 28);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(108, 24);
            this.lbl_employee.TabIndex = 10;
            this.lbl_employee.Text = "Mitarbeiter";
            // 
            // lbl_storageHeadline
            // 
            this.lbl_storageHeadline.AutoSize = true;
            this.lbl_storageHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storageHeadline.Location = new System.Drawing.Point(37, 89);
            this.lbl_storageHeadline.Name = "lbl_storageHeadline";
            this.lbl_storageHeadline.Size = new System.Drawing.Size(152, 18);
            this.lbl_storageHeadline.TabIndex = 11;
            this.lbl_storageHeadline.Text = "Mitarbeiter hinzufügen";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.Location = new System.Drawing.Point(37, 156);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(71, 15);
            this.lbl_surname.TabIndex = 14;
            this.lbl_surname.Text = "Nachname:";
            // 
            // lbl_password2
            // 
            this.lbl_password2.AutoSize = true;
            this.lbl_password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password2.Location = new System.Drawing.Point(37, 260);
            this.lbl_password2.Name = "lbl_password2";
            this.lbl_password2.Size = new System.Drawing.Size(60, 15);
            this.lbl_password2.TabIndex = 15;
            this.lbl_password2.Text = "Passwort:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(37, 232);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(60, 15);
            this.lbl_password.TabIndex = 16;
            this.lbl_password.Text = "Passwort:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(37, 207);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(91, 15);
            this.lbl_username.TabIndex = 17;
            this.lbl_username.Text = "Benutzername:";
            // 
            // txtB_name
            // 
            this.txtB_name.Location = new System.Drawing.Point(144, 130);
            this.txtB_name.Name = "txtB_name";
            this.txtB_name.Size = new System.Drawing.Size(100, 20);
            this.txtB_name.TabIndex = 19;
            // 
            // txtB_surname
            // 
            this.txtB_surname.Location = new System.Drawing.Point(144, 156);
            this.txtB_surname.Name = "txtB_surname";
            this.txtB_surname.Size = new System.Drawing.Size(100, 20);
            this.txtB_surname.TabIndex = 20;
            // 
            // txtB_username
            // 
            this.txtB_username.Location = new System.Drawing.Point(144, 206);
            this.txtB_username.Name = "txtB_username";
            this.txtB_username.Size = new System.Drawing.Size(100, 20);
            this.txtB_username.TabIndex = 21;
            // 
            // txtB_password
            // 
            this.txtB_password.Location = new System.Drawing.Point(144, 232);
            this.txtB_password.Name = "txtB_password";
            this.txtB_password.Size = new System.Drawing.Size(100, 20);
            this.txtB_password.TabIndex = 22;
            // 
            // txtB_password2
            // 
            this.txtB_password2.Location = new System.Drawing.Point(144, 260);
            this.txtB_password2.Name = "txtB_password2";
            this.txtB_password2.Size = new System.Drawing.Size(100, 20);
            this.txtB_password2.TabIndex = 23;
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(366, 326);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(75, 23);
            this.bttn_save.TabIndex = 24;
            this.bttn_save.Text = "speichern";
            this.bttn_save.UseVisualStyleBackColor = true;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(40, 326);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(75, 23);
            this.bttn_back.TabIndex = 25;
            this.bttn_back.Text = "zurück";
            this.bttn_back.UseVisualStyleBackColor = true;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click_1);
            // 
            // bttn_seeAll
            // 
            this.bttn_seeAll.Location = new System.Drawing.Point(355, 282);
            this.bttn_seeAll.Name = "bttn_seeAll";
            this.bttn_seeAll.Size = new System.Drawing.Size(86, 39);
            this.bttn_seeAll.TabIndex = 26;
            this.bttn_seeAll.Text = "alle Mitarbeiter anzeigen";
            this.bttn_seeAll.UseVisualStyleBackColor = true;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(37, 130);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 13);
            this.lbl_name.TabIndex = 27;
            this.lbl_name.Text = "Vorname:";
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 372);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.bttn_seeAll);
            this.Controls.Add(this.bttn_back);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.txtB_password2);
            this.Controls.Add(this.txtB_password);
            this.Controls.Add(this.txtB_username);
            this.Controls.Add(this.txtB_surname);
            this.Controls.Add(this.txtB_name);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_password2);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_storageHeadline);
            this.Controls.Add(this.lbl_employee);
            this.Name = "addEmployee";
            this.Text = "addEmployee";
            this.Load += new System.EventHandler(this.addEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.Label lbl_storageHeadline;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_password2;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txtB_name;
        private System.Windows.Forms.TextBox txtB_surname;
        private System.Windows.Forms.TextBox txtB_username;
        private System.Windows.Forms.TextBox txtB_password;
        private System.Windows.Forms.TextBox txtB_password2;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_back;
        private System.Windows.Forms.Button bttn_seeAll;
        private System.Windows.Forms.Label lbl_name;
    }
}