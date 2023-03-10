namespace Lagerverwaltung
{
    partial class buy
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
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_back = new System.Windows.Forms.Button();
            this.cbB_product = new System.Windows.Forms.ComboBox();
            this.lbl_product = new System.Windows.Forms.Label();
            this.dgV_buy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_buy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_headline
            // 
            this.lbl_headline.AutoSize = true;
            this.lbl_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headline.Location = new System.Drawing.Point(23, 31);
            this.lbl_headline.Name = "lbl_headline";
            this.lbl_headline.Size = new System.Drawing.Size(63, 20);
            this.lbl_headline.TabIndex = 8;
            this.lbl_headline.Text = "Einkauf";
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(538, 404);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(75, 23);
            this.bttn_save.TabIndex = 16;
            this.bttn_save.Text = "speichern";
            this.bttn_save.UseVisualStyleBackColor = true;
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(27, 404);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(75, 23);
            this.bttn_back.TabIndex = 17;
            this.bttn_back.Text = "zurück";
            this.bttn_back.UseVisualStyleBackColor = true;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click_1);
            // 
            // cbB_product
            // 
            this.cbB_product.FormattingEnabled = true;
            this.cbB_product.Location = new System.Drawing.Point(102, 77);
            this.cbB_product.Name = "cbB_product";
            this.cbB_product.Size = new System.Drawing.Size(121, 21);
            this.cbB_product.TabIndex = 18;
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(24, 85);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(44, 13);
            this.lbl_product.TabIndex = 19;
            this.lbl_product.Text = "Produkt";
            // 
            // dgV_buy
            // 
            this.dgV_buy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_buy.Location = new System.Drawing.Point(27, 129);
            this.dgV_buy.Name = "dgV_buy";
            this.dgV_buy.Size = new System.Drawing.Size(586, 260);
            this.dgV_buy.TabIndex = 20;
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.dgV_buy);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.cbB_product);
            this.Controls.Add(this.bttn_back);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.lbl_headline);
            this.Name = "buy";
            this.Text = "buy";
            ((System.ComponentModel.ISupportInitialize)(this.dgV_buy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_headline;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_back;
        private System.Windows.Forms.ComboBox cbB_product;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.DataGridView dgV_buy;
    }
}