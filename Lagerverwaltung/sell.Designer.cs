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
            this.lbl_product = new System.Windows.Forms.Label();
            this.lbl_seller = new System.Windows.Forms.Label();
            this.cB_product = new System.Windows.Forms.ComboBox();
            this.txtB_buyer = new System.Windows.Forms.TextBox();
            this.txtB_discountS = new System.Windows.Forms.TextBox();
            this.txtB_discountR = new System.Windows.Forms.TextBox();
            this.lbl_discountS = new System.Windows.Forms.Label();
            this.lbl_discountR = new System.Windows.Forms.Label();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_back = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            this.txtB_infos = new System.Windows.Forms.TextBox();
            this.lbl_allCost = new System.Windows.Forms.Label();
            this.txtB_allCost = new System.Windows.Forms.TextBox();
            this.lbl_ust = new System.Windows.Forms.Label();
            this.txtB_ust = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txtB_amount = new System.Windows.Forms.TextBox();
            this.lbl_onePrice = new System.Windows.Forms.Label();
            this.txtB_onePrice = new System.Windows.Forms.TextBox();
            this.bttn_sum = new System.Windows.Forms.Button();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_headline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(31, 62);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(47, 13);
            this.lbl_product.TabIndex = 0;
            this.lbl_product.Text = "Produkt:";
            // 
            // lbl_seller
            // 
            this.lbl_seller.AutoSize = true;
            this.lbl_seller.Location = new System.Drawing.Point(33, 109);
            this.lbl_seller.Name = "lbl_seller";
            this.lbl_seller.Size = new System.Drawing.Size(41, 13);
            this.lbl_seller.TabIndex = 1;
            this.lbl_seller.Text = "Käufer:";
            // 
            // cB_product
            // 
            this.cB_product.FormattingEnabled = true;
            this.cB_product.Location = new System.Drawing.Point(123, 62);
            this.cB_product.Name = "cB_product";
            this.cB_product.Size = new System.Drawing.Size(121, 21);
            this.cB_product.TabIndex = 2;
            this.cB_product.SelectedIndexChanged += new System.EventHandler(this.cB_product_SelectedIndexChanged);
            // 
            // txtB_buyer
            // 
            this.txtB_buyer.Location = new System.Drawing.Point(145, 102);
            this.txtB_buyer.Name = "txtB_buyer";
            this.txtB_buyer.Size = new System.Drawing.Size(100, 20);
            this.txtB_buyer.TabIndex = 3;
            // 
            // txtB_discountS
            // 
            this.txtB_discountS.Location = new System.Drawing.Point(144, 183);
            this.txtB_discountS.Name = "txtB_discountS";
            this.txtB_discountS.Size = new System.Drawing.Size(100, 20);
            this.txtB_discountS.TabIndex = 4;
            // 
            // txtB_discountR
            // 
            this.txtB_discountR.Location = new System.Drawing.Point(144, 157);
            this.txtB_discountR.Name = "txtB_discountR";
            this.txtB_discountR.Size = new System.Drawing.Size(100, 20);
            this.txtB_discountR.TabIndex = 5;
            // 
            // lbl_discountS
            // 
            this.lbl_discountS.AutoSize = true;
            this.lbl_discountS.Location = new System.Drawing.Point(31, 186);
            this.lbl_discountS.Name = "lbl_discountS";
            this.lbl_discountS.Size = new System.Drawing.Size(78, 13);
            this.lbl_discountS.TabIndex = 6;
            this.lbl_discountS.Text = "Skonto ( in % ):";
            // 
            // lbl_discountR
            // 
            this.lbl_discountR.AutoSize = true;
            this.lbl_discountR.Location = new System.Drawing.Point(31, 160);
            this.lbl_discountR.Name = "lbl_discountR";
            this.lbl_discountR.Size = new System.Drawing.Size(76, 13);
            this.lbl_discountR.TabIndex = 7;
            this.lbl_discountR.Text = "Rabatt ( in % ):";
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(354, 396);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(75, 23);
            this.bttn_save.TabIndex = 8;
            this.bttn_save.Text = "Verkaufen";
            this.bttn_save.UseVisualStyleBackColor = true;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(47, 396);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(75, 23);
            this.bttn_back.TabIndex = 9;
            this.bttn_back.Text = "Abbrechen";
            this.bttn_back.UseVisualStyleBackColor = true;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(300, 62);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(117, 13);
            this.lbl_info.TabIndex = 10;
            this.lbl_info.Text = "Weitere Informationen: ";
            // 
            // txtB_infos
            // 
            this.txtB_infos.Location = new System.Drawing.Point(295, 102);
            this.txtB_infos.Multiline = true;
            this.txtB_infos.Name = "txtB_infos";
            this.txtB_infos.Size = new System.Drawing.Size(134, 101);
            this.txtB_infos.TabIndex = 11;
            // 
            // lbl_allCost
            // 
            this.lbl_allCost.AutoSize = true;
            this.lbl_allCost.Location = new System.Drawing.Point(31, 351);
            this.lbl_allCost.Name = "lbl_allCost";
            this.lbl_allCost.Size = new System.Drawing.Size(46, 13);
            this.lbl_allCost.TabIndex = 12;
            this.lbl_allCost.Text = "Gesamt:";
            // 
            // txtB_allCost
            // 
            this.txtB_allCost.Location = new System.Drawing.Point(144, 344);
            this.txtB_allCost.Name = "txtB_allCost";
            this.txtB_allCost.ReadOnly = true;
            this.txtB_allCost.Size = new System.Drawing.Size(100, 20);
            this.txtB_allCost.TabIndex = 13;
            // 
            // lbl_ust
            // 
            this.lbl_ust.AutoSize = true;
            this.lbl_ust.Location = new System.Drawing.Point(31, 217);
            this.lbl_ust.Name = "lbl_ust";
            this.lbl_ust.Size = new System.Drawing.Size(26, 13);
            this.lbl_ust.TabIndex = 14;
            this.lbl_ust.Text = "Ust:";
            // 
            // txtB_ust
            // 
            this.txtB_ust.Location = new System.Drawing.Point(144, 214);
            this.txtB_ust.Name = "txtB_ust";
            this.txtB_ust.ReadOnly = true;
            this.txtB_ust.Size = new System.Drawing.Size(100, 20);
            this.txtB_ust.TabIndex = 15;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(31, 280);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_amount.TabIndex = 16;
            this.lbl_amount.Text = "Menge:";
            // 
            // txtB_amount
            // 
            this.txtB_amount.Location = new System.Drawing.Point(144, 280);
            this.txtB_amount.Name = "txtB_amount";
            this.txtB_amount.Size = new System.Drawing.Size(100, 20);
            this.txtB_amount.TabIndex = 17;
            // 
            // lbl_onePrice
            // 
            this.lbl_onePrice.AutoSize = true;
            this.lbl_onePrice.Location = new System.Drawing.Point(33, 134);
            this.lbl_onePrice.Name = "lbl_onePrice";
            this.lbl_onePrice.Size = new System.Drawing.Size(112, 13);
            this.lbl_onePrice.TabIndex = 18;
            this.lbl_onePrice.Text = "Einzelpreis (ohne Ust):";
            // 
            // txtB_onePrice
            // 
            this.txtB_onePrice.Location = new System.Drawing.Point(145, 131);
            this.txtB_onePrice.Name = "txtB_onePrice";
            this.txtB_onePrice.ReadOnly = true;
            this.txtB_onePrice.Size = new System.Drawing.Size(100, 20);
            this.txtB_onePrice.TabIndex = 19;
            // 
            // bttn_sum
            // 
            this.bttn_sum.Location = new System.Drawing.Point(145, 306);
            this.bttn_sum.Name = "bttn_sum";
            this.bttn_sum.Size = new System.Drawing.Size(99, 35);
            this.bttn_sum.TabIndex = 20;
            this.bttn_sum.Text = "Gesamtpreis ausrechen";
            this.bttn_sum.UseVisualStyleBackColor = true;
            this.bttn_sum.Click += new System.EventHandler(this.bttn_sum_Click);
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(142, 264);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(73, 13);
            this.lbl_stock.TabIndex = 21;
            this.lbl_stock.Text = "vorh. Menge: ";
            // 
            // lbl_headline
            // 
            this.lbl_headline.AutoSize = true;
            this.lbl_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headline.Location = new System.Drawing.Point(30, 18);
            this.lbl_headline.Name = "lbl_headline";
            this.lbl_headline.Size = new System.Drawing.Size(81, 24);
            this.lbl_headline.TabIndex = 25;
            this.lbl_headline.Text = "Verkauf";
            // 
            // sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.lbl_headline);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.bttn_sum);
            this.Controls.Add(this.txtB_onePrice);
            this.Controls.Add(this.lbl_onePrice);
            this.Controls.Add(this.txtB_amount);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.txtB_ust);
            this.Controls.Add(this.lbl_ust);
            this.Controls.Add(this.txtB_allCost);
            this.Controls.Add(this.lbl_allCost);
            this.Controls.Add(this.txtB_infos);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.bttn_back);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.lbl_discountR);
            this.Controls.Add(this.lbl_discountS);
            this.Controls.Add(this.txtB_discountR);
            this.Controls.Add(this.txtB_discountS);
            this.Controls.Add(this.txtB_buyer);
            this.Controls.Add(this.cB_product);
            this.Controls.Add(this.lbl_seller);
            this.Controls.Add(this.lbl_product);
            this.Name = "sell";
            this.Text = "Produkt verkaufen";
            this.Load += new System.EventHandler(this.sell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_seller;
        private System.Windows.Forms.ComboBox cB_product;
        private System.Windows.Forms.TextBox txtB_buyer;
        private System.Windows.Forms.TextBox txtB_discountS;
        private System.Windows.Forms.TextBox txtB_discountR;
        private System.Windows.Forms.Label lbl_discountS;
        private System.Windows.Forms.Label lbl_discountR;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_back;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox txtB_infos;
        private System.Windows.Forms.Label lbl_allCost;
        private System.Windows.Forms.TextBox txtB_allCost;
        private System.Windows.Forms.Label lbl_ust;
        private System.Windows.Forms.TextBox txtB_ust;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txtB_amount;
        private System.Windows.Forms.Label lbl_onePrice;
        private System.Windows.Forms.TextBox txtB_onePrice;
        private System.Windows.Forms.Button bttn_sum;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_headline;
    }
}