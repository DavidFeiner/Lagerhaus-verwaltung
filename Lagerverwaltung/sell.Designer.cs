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
            this.lbl_buyer = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.lbl_discountS = new System.Windows.Forms.Label();
            this.lbl_discountR = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_priceN = new System.Windows.Forms.Label();
            this.lbl_ust = new System.Windows.Forms.Label();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_back = new System.Windows.Forms.Button();
            this.txtB_product = new System.Windows.Forms.TextBox();
            this.txtB_buyer = new System.Windows.Forms.TextBox();
            this.txtB_priceB = new System.Windows.Forms.TextBox();
            this.txtB_ust = new System.Windows.Forms.TextBox();
            this.txtB_priceN = new System.Windows.Forms.TextBox();
            this.txtB_discountS = new System.Windows.Forms.TextBox();
            this.txtB_discountR = new System.Windows.Forms.TextBox();
            this.txtB_quantity = new System.Windows.Forms.TextBox();
            this.txtB_price = new System.Windows.Forms.TextBox();
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
            // lbl_buyer
            // 
            this.lbl_buyer.AutoSize = true;
            this.lbl_buyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buyer.Location = new System.Drawing.Point(405, 94);
            this.lbl_buyer.Name = "lbl_buyer";
            this.lbl_buyer.Size = new System.Drawing.Size(48, 16);
            this.lbl_buyer.TabIndex = 21;
            this.lbl_buyer.Text = "Käufer:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(23, 120);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(76, 16);
            this.lbl_price.TabIndex = 20;
            this.lbl_price.Text = "Einzelpreis:";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(23, 280);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(125, 16);
            this.lbl_totalPrice.TabIndex = 19;
            this.lbl_totalPrice.Text = "Bruttoverkaufspreis:";
            // 
            // lbl_discountS
            // 
            this.lbl_discountS.AutoSize = true;
            this.lbl_discountS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discountS.Location = new System.Drawing.Point(23, 200);
            this.lbl_discountS.Name = "lbl_discountS";
            this.lbl_discountS.Size = new System.Drawing.Size(52, 16);
            this.lbl_discountS.TabIndex = 18;
            this.lbl_discountS.Text = "Skonto:";
            // 
            // lbl_discountR
            // 
            this.lbl_discountR.AutoSize = true;
            this.lbl_discountR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discountR.Location = new System.Drawing.Point(23, 174);
            this.lbl_discountR.Name = "lbl_discountR";
            this.lbl_discountR.Size = new System.Drawing.Size(50, 16);
            this.lbl_discountR.TabIndex = 17;
            this.lbl_discountR.Text = "Rabatt:";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(23, 147);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(52, 16);
            this.lbl_quantity.TabIndex = 16;
            this.lbl_quantity.Text = "Menge:";
            // 
            // lbl_priceN
            // 
            this.lbl_priceN.AutoSize = true;
            this.lbl_priceN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priceN.Location = new System.Drawing.Point(23, 225);
            this.lbl_priceN.Name = "lbl_priceN";
            this.lbl_priceN.Size = new System.Drawing.Size(72, 16);
            this.lbl_priceN.TabIndex = 22;
            this.lbl_priceN.Text = "Nettopreis:";
            // 
            // lbl_ust
            // 
            this.lbl_ust.AutoSize = true;
            this.lbl_ust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ust.Location = new System.Drawing.Point(27, 252);
            this.lbl_ust.Name = "lbl_ust";
            this.lbl_ust.Size = new System.Drawing.Size(37, 16);
            this.lbl_ust.TabIndex = 23;
            this.lbl_ust.Text = "+Ust:";
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(26, 398);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(75, 23);
            this.bttn_save.TabIndex = 24;
            this.bttn_save.Text = "speichern";
            this.bttn_save.UseVisualStyleBackColor = true;
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(535, 398);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(75, 23);
            this.bttn_back.TabIndex = 25;
            this.bttn_back.Text = "zurück";
            this.bttn_back.UseVisualStyleBackColor = true;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click_1);
            // 
            // txtB_product
            // 
            this.txtB_product.Location = new System.Drawing.Point(175, 93);
            this.txtB_product.Name = "txtB_product";
            this.txtB_product.Size = new System.Drawing.Size(100, 20);
            this.txtB_product.TabIndex = 26;
            // 
            // txtB_buyer
            // 
            this.txtB_buyer.Location = new System.Drawing.Point(510, 89);
            this.txtB_buyer.Name = "txtB_buyer";
            this.txtB_buyer.Size = new System.Drawing.Size(100, 20);
            this.txtB_buyer.TabIndex = 28;
            // 
            // txtB_priceB
            // 
            this.txtB_priceB.Location = new System.Drawing.Point(175, 280);
            this.txtB_priceB.Name = "txtB_priceB";
            this.txtB_priceB.Size = new System.Drawing.Size(100, 20);
            this.txtB_priceB.TabIndex = 29;
            // 
            // txtB_ust
            // 
            this.txtB_ust.Location = new System.Drawing.Point(175, 251);
            this.txtB_ust.Name = "txtB_ust";
            this.txtB_ust.Size = new System.Drawing.Size(100, 20);
            this.txtB_ust.TabIndex = 30;
            // 
            // txtB_priceN
            // 
            this.txtB_priceN.Location = new System.Drawing.Point(175, 222);
            this.txtB_priceN.Name = "txtB_priceN";
            this.txtB_priceN.Size = new System.Drawing.Size(100, 20);
            this.txtB_priceN.TabIndex = 31;
            // 
            // txtB_discountS
            // 
            this.txtB_discountS.Location = new System.Drawing.Point(175, 196);
            this.txtB_discountS.Name = "txtB_discountS";
            this.txtB_discountS.Size = new System.Drawing.Size(100, 20);
            this.txtB_discountS.TabIndex = 32;
            // 
            // txtB_discountR
            // 
            this.txtB_discountR.Location = new System.Drawing.Point(175, 173);
            this.txtB_discountR.Name = "txtB_discountR";
            this.txtB_discountR.Size = new System.Drawing.Size(100, 20);
            this.txtB_discountR.TabIndex = 33;
            // 
            // txtB_quantity
            // 
            this.txtB_quantity.Location = new System.Drawing.Point(175, 147);
            this.txtB_quantity.Name = "txtB_quantity";
            this.txtB_quantity.Size = new System.Drawing.Size(100, 20);
            this.txtB_quantity.TabIndex = 34;
            // 
            // txtB_price
            // 
            this.txtB_price.Location = new System.Drawing.Point(175, 120);
            this.txtB_price.Name = "txtB_price";
            this.txtB_price.Size = new System.Drawing.Size(100, 20);
            this.txtB_price.TabIndex = 35;
            // 
            // sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.txtB_price);
            this.Controls.Add(this.txtB_quantity);
            this.Controls.Add(this.txtB_discountR);
            this.Controls.Add(this.txtB_discountS);
            this.Controls.Add(this.txtB_priceN);
            this.Controls.Add(this.txtB_ust);
            this.Controls.Add(this.txtB_priceB);
            this.Controls.Add(this.txtB_buyer);
            this.Controls.Add(this.txtB_product);
            this.Controls.Add(this.bttn_back);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.lbl_ust);
            this.Controls.Add(this.lbl_priceN);
            this.Controls.Add(this.lbl_buyer);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_discountS);
            this.Controls.Add(this.lbl_discountR);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.lbl_headline);
            this.Name = "sell";
            this.Text = "sell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_headline;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_buyer;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label lbl_discountS;
        private System.Windows.Forms.Label lbl_discountR;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_priceN;
        private System.Windows.Forms.Label lbl_ust;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_back;
        private System.Windows.Forms.TextBox txtB_product;
        private System.Windows.Forms.TextBox txtB_buyer;
        private System.Windows.Forms.TextBox txtB_priceB;
        private System.Windows.Forms.TextBox txtB_ust;
        private System.Windows.Forms.TextBox txtB_priceN;
        private System.Windows.Forms.TextBox txtB_discountS;
        private System.Windows.Forms.TextBox txtB_discountR;
        private System.Windows.Forms.TextBox txtB_quantity;
        private System.Windows.Forms.TextBox txtB_price;
    }
}