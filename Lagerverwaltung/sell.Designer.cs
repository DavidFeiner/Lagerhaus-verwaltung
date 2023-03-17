namespace Lagerverwaltung
{
    partial class sell
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
            this.lbl_headline = new System.Windows.Forms.Label();
            this.lbl_product = new System.Windows.Forms.Label();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_back = new System.Windows.Forms.Button();
            this.ProduktCmbx = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LabelValue = new System.Windows.Forms.Label();
            this.LabelMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_headline
            // 
            this.lbl_headline.AutoSize = true;
            this.lbl_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headline.Location = new System.Drawing.Point(22, 31);
            this.lbl_headline.Name = "lbl_headline";
            this.lbl_headline.Size = new System.Drawing.Size(65, 20);
            this.lbl_headline.TabIndex = 9;
            this.lbl_headline.Text = "Verkauf";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product.Location = new System.Drawing.Point(23, 93);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(56, 16);
            this.lbl_product.TabIndex = 10;
            this.lbl_product.Text = "Produkt:";
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(535, 398);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(75, 23);
            this.bttn_save.TabIndex = 24;
            this.bttn_save.Text = "speichern";
            this.bttn_save.UseVisualStyleBackColor = true;
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(26, 398);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(75, 23);
            this.bttn_back.TabIndex = 25;
            this.bttn_back.Text = "zurück";
            this.bttn_back.UseVisualStyleBackColor = true;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click_1);
            // 
            // ProduktCmbx
            // 
            this.ProduktCmbx.FormattingEnabled = true;
            this.ProduktCmbx.Location = new System.Drawing.Point(109, 88);
            this.ProduktCmbx.Name = "ProduktCmbx";
            this.ProduktCmbx.Size = new System.Drawing.Size(121, 21);
            this.ProduktCmbx.TabIndex = 26;
            this.ProduktCmbx.SelectedIndexChanged += new System.EventHandler(this.ProduktCmbx_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 258);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LabelValue
            // 
            this.LabelValue.AutoSize = true;
            this.LabelValue.Location = new System.Drawing.Point(520, 31);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(40, 13);
            this.LabelValue.TabIndex = 28;
            this.LabelValue.Text = "Menge";
            this.LabelValue.Click += new System.EventHandler(this.LabelValue_Click);
            // 
            // LabelMoney
            // 
            this.LabelMoney.AutoSize = true;
            this.LabelMoney.Location = new System.Drawing.Point(523, 61);
            this.LabelMoney.Name = "LabelMoney";
            this.LabelMoney.Size = new System.Drawing.Size(29, 13);
            this.LabelMoney.TabIndex = 29;
            this.LabelMoney.Text = "Geld";
            this.LabelMoney.Click += new System.EventHandler(this.LabelMoney_Click);
            // 
            // sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.LabelMoney);
            this.Controls.Add(this.LabelValue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProduktCmbx);
            this.Controls.Add(this.bttn_back);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.lbl_headline);
            this.Name = "sell";
            this.Text = "sell";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_headline;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_back;
        private System.Windows.Forms.ComboBox ProduktCmbx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.Label LabelMoney;
    }
}