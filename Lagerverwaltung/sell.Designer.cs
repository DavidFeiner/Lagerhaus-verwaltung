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
            this.SuspendLayout();
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(45, 65);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(47, 13);
            this.lbl_product.TabIndex = 0;
            this.lbl_product.Text = "Produkt:";
            // 
            // lbl_seller
            // 
            this.lbl_seller.AutoSize = true;
            this.lbl_seller.Location = new System.Drawing.Point(45, 105);
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
            // 
            // sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.cB_product);
            this.Controls.Add(this.lbl_seller);
            this.Controls.Add(this.lbl_product);
            this.Name = "sell";
            this.Text = "Produkte verkaufen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_seller;
        private System.Windows.Forms.ComboBox cB_product;
    }
}