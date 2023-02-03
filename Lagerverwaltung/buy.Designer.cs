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
            this.lbl_product = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_discountR = new System.Windows.Forms.Label();
            this.lbl_discountS = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_back = new System.Windows.Forms.Button();
            this.txtB_product = new System.Windows.Forms.TextBox();
            this.txtB_discountR = new System.Windows.Forms.TextBox();
            this.txtB_discountS = new System.Windows.Forms.TextBox();
            this.txtB_totalPrice = new System.Windows.Forms.TextBox();
            this.txtB_price = new System.Windows.Forms.TextBox();
            this.txtB_supplier = new System.Windows.Forms.TextBox();
            this.txtB_quantity = new System.Windows.Forms.TextBox();
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
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product.Location = new System.Drawing.Point(27, 102);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(56, 16);
            this.lbl_product.TabIndex = 9;
            this.lbl_product.Text = "Produkt:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(27, 127);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(52, 16);
            this.lbl_quantity.TabIndex = 10;
            this.lbl_quantity.Text = "Menge:";
            // 
            // lbl_discountR
            // 
            this.lbl_discountR.AutoSize = true;
            this.lbl_discountR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discountR.Location = new System.Drawing.Point(416, 127);
            this.lbl_discountR.Name = "lbl_discountR";
            this.lbl_discountR.Size = new System.Drawing.Size(50, 16);
            this.lbl_discountR.TabIndex = 11;
            this.lbl_discountR.Text = "Rabatt:";
            // 
            // lbl_discountS
            // 
            this.lbl_discountS.AutoSize = true;
            this.lbl_discountS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discountS.Location = new System.Drawing.Point(416, 101);
            this.lbl_discountS.Name = "lbl_discountS";
            this.lbl_discountS.Size = new System.Drawing.Size(52, 16);
            this.lbl_discountS.TabIndex = 12;
            this.lbl_discountS.Text = "Skonto:";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(27, 217);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(87, 16);
            this.lbl_totalPrice.TabIndex = 13;
            this.lbl_totalPrice.Text = "Gesamtpreis:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(27, 178);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(76, 16);
            this.lbl_price.TabIndex = 14;
            this.lbl_price.Text = "Einzelpreis:";
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplier.Location = new System.Drawing.Point(27, 153);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(61, 16);
            this.lbl_supplier.TabIndex = 15;
            this.lbl_supplier.Text = "Lieferant:";
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(27, 395);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(75, 23);
            this.bttn_save.TabIndex = 16;
            this.bttn_save.Text = "speichern";
            this.bttn_save.UseVisualStyleBackColor = true;
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(538, 395);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(75, 23);
            this.bttn_back.TabIndex = 17;
            this.bttn_back.Text = "zurück";
            this.bttn_back.UseVisualStyleBackColor = true;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click_1);
            // 
            // txtB_product
            // 
            this.txtB_product.Location = new System.Drawing.Point(138, 97);
            this.txtB_product.Name = "txtB_product";
            this.txtB_product.Size = new System.Drawing.Size(100, 20);
            this.txtB_product.TabIndex = 18;
            // 
            // txtB_discountR
            // 
            this.txtB_discountR.Location = new System.Drawing.Point(513, 127);
            this.txtB_discountR.Name = "txtB_discountR";
            this.txtB_discountR.Size = new System.Drawing.Size(100, 20);
            this.txtB_discountR.TabIndex = 19;
            // 
            // txtB_discountS
            // 
            this.txtB_discountS.Location = new System.Drawing.Point(513, 97);
            this.txtB_discountS.Name = "txtB_discountS";
            this.txtB_discountS.Size = new System.Drawing.Size(100, 20);
            this.txtB_discountS.TabIndex = 20;
            // 
            // txtB_totalPrice
            // 
            this.txtB_totalPrice.Location = new System.Drawing.Point(138, 213);
            this.txtB_totalPrice.Name = "txtB_totalPrice";
            this.txtB_totalPrice.Size = new System.Drawing.Size(100, 20);
            this.txtB_totalPrice.TabIndex = 21;
            // 
            // txtB_price
            // 
            this.txtB_price.Location = new System.Drawing.Point(138, 175);
            this.txtB_price.Name = "txtB_price";
            this.txtB_price.Size = new System.Drawing.Size(100, 20);
            this.txtB_price.TabIndex = 22;
            // 
            // txtB_supplier
            // 
            this.txtB_supplier.Location = new System.Drawing.Point(138, 149);
            this.txtB_supplier.Name = "txtB_supplier";
            this.txtB_supplier.Size = new System.Drawing.Size(100, 20);
            this.txtB_supplier.TabIndex = 23;
            // 
            // txtB_quantity
            // 
            this.txtB_quantity.Location = new System.Drawing.Point(138, 123);
            this.txtB_quantity.Name = "txtB_quantity";
            this.txtB_quantity.Size = new System.Drawing.Size(100, 20);
            this.txtB_quantity.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(25, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 387);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.txtB_quantity);
            this.Controls.Add(this.txtB_supplier);
            this.Controls.Add(this.txtB_price);
            this.Controls.Add(this.txtB_totalPrice);
            this.Controls.Add(this.txtB_discountS);
            this.Controls.Add(this.txtB_discountR);
            this.Controls.Add(this.txtB_product);
            this.Controls.Add(this.bttn_back);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.lbl_supplier);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_discountS);
            this.Controls.Add(this.lbl_discountR);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.lbl_headline);
            this.Name = "buy";
            this.Text = "buy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_headline;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_discountR;
        private System.Windows.Forms.Label lbl_discountS;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_back;
        private System.Windows.Forms.TextBox txtB_product;
        private System.Windows.Forms.TextBox txtB_discountR;
        private System.Windows.Forms.TextBox txtB_discountS;
        private System.Windows.Forms.TextBox txtB_totalPrice;
        private System.Windows.Forms.TextBox txtB_price;
        private System.Windows.Forms.TextBox txtB_supplier;
        private System.Windows.Forms.TextBox txtB_quantity;
    }
}