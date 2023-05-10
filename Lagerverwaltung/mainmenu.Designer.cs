namespace Lagerverwaltung
{
    partial class mainmenu
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
            this.bttn_storage = new System.Windows.Forms.Button();
            this.bttn_sales = new System.Windows.Forms.Button();
            this.bttn_buy = new System.Windows.Forms.Button();
            this.bttn_sell = new System.Windows.Forms.Button();
            this.bttn_employee = new System.Windows.Forms.Button();
            this.bttn_signOut = new System.Windows.Forms.Button();
            this.txtB_info = new System.Windows.Forms.TextBox();
            this.lbl_headline2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_storage
            // 
            this.bttn_storage.Location = new System.Drawing.Point(26, 278);
            this.bttn_storage.Name = "bttn_storage";
            this.bttn_storage.Size = new System.Drawing.Size(118, 38);
            this.bttn_storage.TabIndex = 0;
            this.bttn_storage.Text = "Lager";
            this.bttn_storage.UseVisualStyleBackColor = true;
            this.bttn_storage.Click += new System.EventHandler(this.bttn_storage_Click);
            // 
            // bttn_sales
            // 
            this.bttn_sales.Location = new System.Drawing.Point(26, 218);
            this.bttn_sales.Name = "bttn_sales";
            this.bttn_sales.Size = new System.Drawing.Size(118, 38);
            this.bttn_sales.TabIndex = 1;
            this.bttn_sales.Text = "Gewinn";
            this.bttn_sales.UseVisualStyleBackColor = true;
            this.bttn_sales.Click += new System.EventHandler(this.bttn_sales_Click);
            // 
            // bttn_buy
            // 
            this.bttn_buy.Location = new System.Drawing.Point(26, 95);
            this.bttn_buy.Name = "bttn_buy";
            this.bttn_buy.Size = new System.Drawing.Size(118, 38);
            this.bttn_buy.TabIndex = 2;
            this.bttn_buy.Text = "Einkauf";
            this.bttn_buy.UseVisualStyleBackColor = true;
            this.bttn_buy.Click += new System.EventHandler(this.bttn_buy_Click);
            // 
            // bttn_sell
            // 
            this.bttn_sell.Location = new System.Drawing.Point(26, 159);
            this.bttn_sell.Name = "bttn_sell";
            this.bttn_sell.Size = new System.Drawing.Size(118, 38);
            this.bttn_sell.TabIndex = 3;
            this.bttn_sell.Text = "Verkauf";
            this.bttn_sell.UseVisualStyleBackColor = true;
            this.bttn_sell.Click += new System.EventHandler(this.bttn_sell_Click);
            // 
            // bttn_employee
            // 
            this.bttn_employee.Location = new System.Drawing.Point(365, 278);
            this.bttn_employee.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_employee.Name = "bttn_employee";
            this.bttn_employee.Size = new System.Drawing.Size(118, 38);
            this.bttn_employee.TabIndex = 4;
            this.bttn_employee.Text = "Mitarbeiter hinzufügen";
            this.bttn_employee.UseVisualStyleBackColor = true;
            this.bttn_employee.Click += new System.EventHandler(this.bttn_employee_Click);
            // 
            // bttn_signOut
            // 
            this.bttn_signOut.Location = new System.Drawing.Point(500, 278);
            this.bttn_signOut.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_signOut.Name = "bttn_signOut";
            this.bttn_signOut.Size = new System.Drawing.Size(118, 38);
            this.bttn_signOut.TabIndex = 5;
            this.bttn_signOut.Text = "abmelden";
            this.bttn_signOut.UseVisualStyleBackColor = true;
            this.bttn_signOut.Click += new System.EventHandler(this.bttn_signOut_Click);
            // 
            // txtB_info
            // 
            this.txtB_info.Location = new System.Drawing.Point(179, 95);
            this.txtB_info.Margin = new System.Windows.Forms.Padding(2);
            this.txtB_info.Multiline = true;
            this.txtB_info.Name = "txtB_info";
            this.txtB_info.Size = new System.Drawing.Size(439, 170);
            this.txtB_info.TabIndex = 6;
            // 
            // lbl_headline2
            // 
            this.lbl_headline2.AutoSize = true;
            this.lbl_headline2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headline2.Location = new System.Drawing.Point(248, 34);
            this.lbl_headline2.Name = "lbl_headline2";
            this.lbl_headline2.Size = new System.Drawing.Size(164, 24);
            this.lbl_headline2.TabIndex = 7;
            this.lbl_headline2.Text = "Lagerverwaltung";
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 352);
            this.Controls.Add(this.lbl_headline2);
            this.Controls.Add(this.txtB_info);
            this.Controls.Add(this.bttn_signOut);
            this.Controls.Add(this.bttn_employee);
            this.Controls.Add(this.bttn_sell);
            this.Controls.Add(this.bttn_buy);
            this.Controls.Add(this.bttn_sales);
            this.Controls.Add(this.bttn_storage);
            this.Name = "mainmenu";
            this.Text = "mainmenu";
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_storage;
        private System.Windows.Forms.Button bttn_sales;
        private System.Windows.Forms.Button bttn_buy;
        private System.Windows.Forms.Button bttn_sell;
        private System.Windows.Forms.Button bttn_employee;
        private System.Windows.Forms.Button bttn_signOut;
        private System.Windows.Forms.TextBox txtB_info;
        private System.Windows.Forms.Label lbl_headline2;
    }
}