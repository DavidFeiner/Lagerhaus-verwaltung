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
            this.txtB_sales = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_buySell = new System.Windows.Forms.Label();
            this.lbl_sales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(557, 382);
            this.bttn_back.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(72, 20);
            this.bttn_back.TabIndex = 7;
            this.bttn_back.Text = "zurück";
            this.bttn_back.UseVisualStyleBackColor = true;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click);
            // 
            // txtB_sales
            // 
            this.txtB_sales.Location = new System.Drawing.Point(142, 382);
            this.txtB_sales.Name = "txtB_sales";
            this.txtB_sales.ReadOnly = true;
            this.txtB_sales.Size = new System.Drawing.Size(100, 20);
            this.txtB_sales.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 311);
            this.dataGridView1.TabIndex = 14;
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
            this.lbl_sales.Location = new System.Drawing.Point(13, 385);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(83, 13);
            this.lbl_sales.TabIndex = 16;
            this.lbl_sales.Text = "Gewinn/Verlust:";
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 413);
            this.Controls.Add(this.lbl_sales);
            this.Controls.Add(this.lbl_buySell);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtB_sales);
            this.Controls.Add(this.bttn_back);
            this.Name = "sales";
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_back;
        private System.Windows.Forms.TextBox txtB_sales;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_buySell;
        private System.Windows.Forms.Label lbl_sales;
    }
}