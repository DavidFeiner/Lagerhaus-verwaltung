namespace Lagerverwaltung
{
    partial class sales
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
            this.bttn_back = new System.Windows.Forms.Button();
            this.txtBoxProfit = new System.Windows.Forms.TextBox();
            this.lbl_buySell = new System.Windows.Forms.Label();
            this.lbl_sales = new System.Windows.Forms.Label();
            this.textBoxExpencis = new System.Windows.Forms.TextBox();
            this.textBoxSales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(552, 173);
            this.bttn_back.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(72, 20);
            this.bttn_back.TabIndex = 7;
            this.bttn_back.Text = "zurück";
            this.bttn_back.UseVisualStyleBackColor = true;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click);
            // 
            // txtBoxProfit
            // 
            this.txtBoxProfit.Location = new System.Drawing.Point(542, 113);
            this.txtBoxProfit.Name = "txtBoxProfit";
            this.txtBoxProfit.ReadOnly = true;
            this.txtBoxProfit.Size = new System.Drawing.Size(100, 20);
            this.txtBoxProfit.TabIndex = 13;
            // 
            // lbl_buySell
            // 
            this.lbl_buySell.AutoSize = true;
            this.lbl_buySell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buySell.Location = new System.Drawing.Point(21, 23);
            this.lbl_buySell.Name = "lbl_buySell";
            this.lbl_buySell.Size = new System.Drawing.Size(180, 24);
            this.lbl_buySell.TabIndex = 15;
            this.lbl_buySell.Text = "Einkäufe/Verkäufe";
            // 
            // lbl_sales
            // 
            this.lbl_sales.AutoSize = true;
            this.lbl_sales.Location = new System.Drawing.Point(413, 116);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(83, 13);
            this.lbl_sales.TabIndex = 16;
            this.lbl_sales.Text = "Gewinn/Verlust:";
            // 
            // textBoxExpencis
            // 
            this.textBoxExpencis.Location = new System.Drawing.Point(276, 116);
            this.textBoxExpencis.Name = "textBoxExpencis";
            this.textBoxExpencis.Size = new System.Drawing.Size(100, 20);
            this.textBoxExpencis.TabIndex = 17;
            // 
            // textBoxSales
            // 
            this.textBoxSales.Location = new System.Drawing.Point(101, 116);
            this.textBoxSales.Name = "textBoxSales";
            this.textBoxSales.Size = new System.Drawing.Size(100, 20);
            this.textBoxSales.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Einnahmen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ausgaben";
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 209);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSales);
            this.Controls.Add(this.textBoxExpencis);
            this.Controls.Add(this.lbl_sales);
            this.Controls.Add(this.lbl_buySell);
            this.Controls.Add(this.txtBoxProfit);
            this.Controls.Add(this.bttn_back);
            this.Name = "sales";
            this.Text = "sales";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_back;
        private System.Windows.Forms.TextBox txtBoxProfit;
        private System.Windows.Forms.Label lbl_buySell;
        private System.Windows.Forms.Label lbl_sales;
        private System.Windows.Forms.TextBox textBoxExpencis;
        private System.Windows.Forms.TextBox textBoxSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}