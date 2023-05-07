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
            this.lbl_existingProducts = new System.Windows.Forms.Label();
            this.cB_existingProduct = new System.Windows.Forms.ComboBox();
            this.lbl_existingQuantity = new System.Windows.Forms.Label();
            this.lbl_existingSupplier = new System.Windows.Forms.Label();
            this.cB_existingSupplier = new System.Windows.Forms.ComboBox();
            this.bttn_newSupplier = new System.Windows.Forms.Button();
            this.lbl_discountS = new System.Windows.Forms.Label();
            this.lbl_discountR = new System.Windows.Forms.Label();
            this.txtB_discountS = new System.Windows.Forms.TextBox();
            this.txtB_discountR = new System.Windows.Forms.TextBox();
            this.lbl_ust = new System.Windows.Forms.Label();
            this.lbl_buyQuantity = new System.Windows.Forms.Label();
            this.txtB_buyQuantity = new System.Windows.Forms.TextBox();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.bttn_buy = new System.Windows.Forms.Button();
            this.lbl_priceOne = new System.Windows.Forms.Label();
            this.txtB_priceOne = new System.Windows.Forms.TextBox();
            this.txtB_totalCost = new System.Windows.Forms.TextBox();
            this.bttn_newProduct = new System.Windows.Forms.Button();
            this.bttn_allCosts = new System.Windows.Forms.Button();
            this.bttn_moreInfoP = new System.Windows.Forms.Button();
            this.bttn_moreInfoS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_existingProducts
            // 
            this.lbl_existingProducts.AutoSize = true;
            this.lbl_existingProducts.Location = new System.Drawing.Point(21, 40);
            this.lbl_existingProducts.Name = "lbl_existingProducts";
            this.lbl_existingProducts.Size = new System.Drawing.Size(47, 13);
            this.lbl_existingProducts.TabIndex = 0;
            this.lbl_existingProducts.Text = "Produkt:";
            // 
            // cB_existingProduct
            // 
            this.cB_existingProduct.FormattingEnabled = true;
            this.cB_existingProduct.Location = new System.Drawing.Point(117, 37);
            this.cB_existingProduct.Name = "cB_existingProduct";
            this.cB_existingProduct.Size = new System.Drawing.Size(121, 21);
            this.cB_existingProduct.TabIndex = 1;
            this.cB_existingProduct.SelectedIndexChanged += new System.EventHandler(this.cB_existingProduct_SelectedIndexChanged);
            // 
            // lbl_existingQuantity
            // 
            this.lbl_existingQuantity.AutoSize = true;
            this.lbl_existingQuantity.Location = new System.Drawing.Point(272, 170);
            this.lbl_existingQuantity.Name = "lbl_existingQuantity";
            this.lbl_existingQuantity.Size = new System.Drawing.Size(103, 13);
            this.lbl_existingQuantity.TabIndex = 2;
            this.lbl_existingQuantity.Text = "vorhandene Menge:";
            // 
            // lbl_existingSupplier
            // 
            this.lbl_existingSupplier.AutoSize = true;
            this.lbl_existingSupplier.Location = new System.Drawing.Point(21, 94);
            this.lbl_existingSupplier.Name = "lbl_existingSupplier";
            this.lbl_existingSupplier.Size = new System.Drawing.Size(63, 13);
            this.lbl_existingSupplier.TabIndex = 3;
            this.lbl_existingSupplier.Text = "Lieferanten:";
            // 
            // cB_existingSupplier
            // 
            this.cB_existingSupplier.FormattingEnabled = true;
            this.cB_existingSupplier.Location = new System.Drawing.Point(117, 91);
            this.cB_existingSupplier.Name = "cB_existingSupplier";
            this.cB_existingSupplier.Size = new System.Drawing.Size(121, 21);
            this.cB_existingSupplier.TabIndex = 4;
            this.cB_existingSupplier.SelectedIndexChanged += new System.EventHandler(this.cB_existingSupplier_SelectedIndexChanged);
            // 
            // bttn_newSupplier
            // 
            this.bttn_newSupplier.Location = new System.Drawing.Point(117, 118);
            this.bttn_newSupplier.Name = "bttn_newSupplier";
            this.bttn_newSupplier.Size = new System.Drawing.Size(121, 23);
            this.bttn_newSupplier.TabIndex = 5;
            this.bttn_newSupplier.Text = "neuer Lieferant";
            this.bttn_newSupplier.UseVisualStyleBackColor = true;
            this.bttn_newSupplier.Click += new System.EventHandler(this.bttn_newSupplier_Click);
            // 
            // lbl_discountS
            // 
            this.lbl_discountS.AutoSize = true;
            this.lbl_discountS.Location = new System.Drawing.Point(24, 170);
            this.lbl_discountS.Name = "lbl_discountS";
            this.lbl_discountS.Size = new System.Drawing.Size(44, 13);
            this.lbl_discountS.TabIndex = 6;
            this.lbl_discountS.Text = "Skonto:";
            // 
            // lbl_discountR
            // 
            this.lbl_discountR.AutoSize = true;
            this.lbl_discountR.Location = new System.Drawing.Point(24, 194);
            this.lbl_discountR.Name = "lbl_discountR";
            this.lbl_discountR.Size = new System.Drawing.Size(39, 13);
            this.lbl_discountR.TabIndex = 7;
            this.lbl_discountR.Text = "Rabatt";
            // 
            // txtB_discountS
            // 
            this.txtB_discountS.Location = new System.Drawing.Point(138, 163);
            this.txtB_discountS.Name = "txtB_discountS";
            this.txtB_discountS.Size = new System.Drawing.Size(100, 20);
            this.txtB_discountS.TabIndex = 8;
            // 
            // txtB_discountR
            // 
            this.txtB_discountR.Location = new System.Drawing.Point(138, 191);
            this.txtB_discountR.Name = "txtB_discountR";
            this.txtB_discountR.Size = new System.Drawing.Size(100, 20);
            this.txtB_discountR.TabIndex = 9;
            // 
            // lbl_ust
            // 
            this.lbl_ust.AutoSize = true;
            this.lbl_ust.Location = new System.Drawing.Point(272, 198);
            this.lbl_ust.Name = "lbl_ust";
            this.lbl_ust.Size = new System.Drawing.Size(32, 13);
            this.lbl_ust.TabIndex = 10;
            this.lbl_ust.Text = "UST:";
            // 
            // lbl_buyQuantity
            // 
            this.lbl_buyQuantity.AutoSize = true;
            this.lbl_buyQuantity.Location = new System.Drawing.Point(24, 268);
            this.lbl_buyQuantity.Name = "lbl_buyQuantity";
            this.lbl_buyQuantity.Size = new System.Drawing.Size(108, 13);
            this.lbl_buyQuantity.TabIndex = 11;
            this.lbl_buyQuantity.Text = "zu kaufende Menge: ";
            // 
            // txtB_buyQuantity
            // 
            this.txtB_buyQuantity.Location = new System.Drawing.Point(138, 261);
            this.txtB_buyQuantity.Name = "txtB_buyQuantity";
            this.txtB_buyQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtB_buyQuantity.TabIndex = 12;
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.Location = new System.Drawing.Point(24, 350);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(92, 13);
            this.lbl_totalCost.TabIndex = 14;
            this.lbl_totalCost.Text = "gesamten Kosten:";
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.Location = new System.Drawing.Point(24, 393);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(75, 23);
            this.bttn_cancel.TabIndex = 15;
            this.bttn_cancel.Text = "Abbrechen";
            this.bttn_cancel.UseVisualStyleBackColor = true;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            // 
            // bttn_buy
            // 
            this.bttn_buy.Location = new System.Drawing.Point(370, 393);
            this.bttn_buy.Name = "bttn_buy";
            this.bttn_buy.Size = new System.Drawing.Size(75, 23);
            this.bttn_buy.TabIndex = 16;
            this.bttn_buy.Text = "Kaufen";
            this.bttn_buy.UseVisualStyleBackColor = true;
            this.bttn_buy.Click += new System.EventHandler(this.bttn_buy_Click);
            // 
            // lbl_priceOne
            // 
            this.lbl_priceOne.AutoSize = true;
            this.lbl_priceOne.Location = new System.Drawing.Point(24, 230);
            this.lbl_priceOne.Name = "lbl_priceOne";
            this.lbl_priceOne.Size = new System.Drawing.Size(106, 13);
            this.lbl_priceOne.TabIndex = 17;
            this.lbl_priceOne.Text = "Einzelpreis ohne Ust:";
            // 
            // txtB_priceOne
            // 
            this.txtB_priceOne.Location = new System.Drawing.Point(138, 227);
            this.txtB_priceOne.Name = "txtB_priceOne";
            this.txtB_priceOne.Size = new System.Drawing.Size(100, 20);
            this.txtB_priceOne.TabIndex = 18;
            // 
            // txtB_totalCost
            // 
            this.txtB_totalCost.Location = new System.Drawing.Point(138, 343);
            this.txtB_totalCost.Name = "txtB_totalCost";
            this.txtB_totalCost.ReadOnly = true;
            this.txtB_totalCost.Size = new System.Drawing.Size(100, 20);
            this.txtB_totalCost.TabIndex = 19;
            // 
            // bttn_newProduct
            // 
            this.bttn_newProduct.Location = new System.Drawing.Point(117, 64);
            this.bttn_newProduct.Name = "bttn_newProduct";
            this.bttn_newProduct.Size = new System.Drawing.Size(121, 23);
            this.bttn_newProduct.TabIndex = 20;
            this.bttn_newProduct.Text = "neues Produkt ";
            this.bttn_newProduct.UseVisualStyleBackColor = true;
            this.bttn_newProduct.Click += new System.EventHandler(this.bttn_newProduct_Click);
            // 
            // bttn_allCosts
            // 
            this.bttn_allCosts.Location = new System.Drawing.Point(135, 300);
            this.bttn_allCosts.Name = "bttn_allCosts";
            this.bttn_allCosts.Size = new System.Drawing.Size(103, 37);
            this.bttn_allCosts.TabIndex = 21;
            this.bttn_allCosts.Text = "Gesamtkosten ausrechnen";
            this.bttn_allCosts.UseVisualStyleBackColor = true;
            this.bttn_allCosts.Click += new System.EventHandler(this.bttn_allCosts_Click);
            // 
            // bttn_moreInfoP
            // 
            this.bttn_moreInfoP.Location = new System.Drawing.Point(275, 35);
            this.bttn_moreInfoP.Name = "bttn_moreInfoP";
            this.bttn_moreInfoP.Size = new System.Drawing.Size(117, 23);
            this.bttn_moreInfoP.TabIndex = 22;
            this.bttn_moreInfoP.Text = "weitere Informationen";
            this.bttn_moreInfoP.UseVisualStyleBackColor = true;
            this.bttn_moreInfoP.Click += new System.EventHandler(this.bttn_moreInfoP_Click);
            // 
            // bttn_moreInfoS
            // 
            this.bttn_moreInfoS.Location = new System.Drawing.Point(275, 91);
            this.bttn_moreInfoS.Name = "bttn_moreInfoS";
            this.bttn_moreInfoS.Size = new System.Drawing.Size(117, 23);
            this.bttn_moreInfoS.TabIndex = 23;
            this.bttn_moreInfoS.Text = "weitere Informationen";
            this.bttn_moreInfoS.UseVisualStyleBackColor = true;
            this.bttn_moreInfoS.Click += new System.EventHandler(this.bttn_moreInfoS_Click);
            // 
            // buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.bttn_moreInfoS);
            this.Controls.Add(this.bttn_moreInfoP);
            this.Controls.Add(this.bttn_allCosts);
            this.Controls.Add(this.bttn_newProduct);
            this.Controls.Add(this.txtB_totalCost);
            this.Controls.Add(this.txtB_priceOne);
            this.Controls.Add(this.lbl_priceOne);
            this.Controls.Add(this.bttn_buy);
            this.Controls.Add(this.bttn_cancel);
            this.Controls.Add(this.lbl_totalCost);
            this.Controls.Add(this.txtB_buyQuantity);
            this.Controls.Add(this.lbl_buyQuantity);
            this.Controls.Add(this.lbl_ust);
            this.Controls.Add(this.txtB_discountR);
            this.Controls.Add(this.txtB_discountS);
            this.Controls.Add(this.lbl_discountR);
            this.Controls.Add(this.lbl_discountS);
            this.Controls.Add(this.bttn_newSupplier);
            this.Controls.Add(this.cB_existingSupplier);
            this.Controls.Add(this.lbl_existingSupplier);
            this.Controls.Add(this.lbl_existingQuantity);
            this.Controls.Add(this.cB_existingProduct);
            this.Controls.Add(this.lbl_existingProducts);
            this.Name = "buy";
            this.Text = "Produkte kaufen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_existingProducts;
        private System.Windows.Forms.ComboBox cB_existingProduct;
        private System.Windows.Forms.Label lbl_existingQuantity;
        private System.Windows.Forms.Label lbl_existingSupplier;
        private System.Windows.Forms.ComboBox cB_existingSupplier;
        private System.Windows.Forms.Button bttn_newSupplier;
        private System.Windows.Forms.Label lbl_discountS;
        private System.Windows.Forms.Label lbl_discountR;
        private System.Windows.Forms.TextBox txtB_discountS;
        private System.Windows.Forms.TextBox txtB_discountR;
        private System.Windows.Forms.Label lbl_ust;
        private System.Windows.Forms.Label lbl_buyQuantity;
        private System.Windows.Forms.TextBox txtB_buyQuantity;
        private System.Windows.Forms.Label lbl_totalCost;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.Button bttn_buy;
        private System.Windows.Forms.Label lbl_priceOne;
        private System.Windows.Forms.TextBox txtB_priceOne;
        private System.Windows.Forms.TextBox txtB_totalCost;
        private System.Windows.Forms.Button bttn_newProduct;
        private System.Windows.Forms.Button bttn_allCosts;
        private System.Windows.Forms.Button bttn_moreInfoP;
        private System.Windows.Forms.Button bttn_moreInfoS;
    }
}