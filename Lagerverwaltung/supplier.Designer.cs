namespace Lagerverwaltung
{
    partial class supplier
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
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.lbl_discountS = new System.Windows.Forms.Label();
            this.lbl_discountR = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_priceOne = new System.Windows.Forms.Label();
            this.lbl_ust = new System.Windows.Forms.Label();
            this.txtB_supplier = new System.Windows.Forms.TextBox();
            this.txtB_discountS = new System.Windows.Forms.TextBox();
            this.txtB_discountR = new System.Windows.Forms.TextBox();
            this.txtB_priceOne = new System.Windows.Forms.TextBox();
            this.txtB_ust = new System.Windows.Forms.TextBox();
            this.txtB_info = new System.Windows.Forms.TextBox();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_cancel = new System.Windows.Forms.Button();
            this.lbl_headline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Location = new System.Drawing.Point(32, 64);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(84, 13);
            this.lbl_supplier.TabIndex = 0;
            this.lbl_supplier.Text = "neuer Lieferant: ";
            // 
            // lbl_discountS
            // 
            this.lbl_discountS.AutoSize = true;
            this.lbl_discountS.Location = new System.Drawing.Point(32, 154);
            this.lbl_discountS.Name = "lbl_discountS";
            this.lbl_discountS.Size = new System.Drawing.Size(44, 13);
            this.lbl_discountS.TabIndex = 1;
            this.lbl_discountS.Text = "Skonto:";
            // 
            // lbl_discountR
            // 
            this.lbl_discountR.AutoSize = true;
            this.lbl_discountR.Location = new System.Drawing.Point(32, 123);
            this.lbl_discountR.Name = "lbl_discountR";
            this.lbl_discountR.Size = new System.Drawing.Size(42, 13);
            this.lbl_discountR.TabIndex = 2;
            this.lbl_discountR.Text = "Rabatt:";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(32, 265);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(124, 13);
            this.lbl_info.TabIndex = 3;
            this.lbl_info.Text = "Genauere Informationen:";
            // 
            // lbl_priceOne
            // 
            this.lbl_priceOne.AutoSize = true;
            this.lbl_priceOne.Location = new System.Drawing.Point(32, 91);
            this.lbl_priceOne.Name = "lbl_priceOne";
            this.lbl_priceOne.Size = new System.Drawing.Size(57, 13);
            this.lbl_priceOne.TabIndex = 4;
            this.lbl_priceOne.Text = "Einzelpreis";
            // 
            // lbl_ust
            // 
            this.lbl_ust.AutoSize = true;
            this.lbl_ust.Location = new System.Drawing.Point(32, 183);
            this.lbl_ust.Name = "lbl_ust";
            this.lbl_ust.Size = new System.Drawing.Size(35, 13);
            this.lbl_ust.TabIndex = 5;
            this.lbl_ust.Text = "UST: ";
            // 
            // txtB_supplier
            // 
            this.txtB_supplier.Location = new System.Drawing.Point(183, 61);
            this.txtB_supplier.Name = "txtB_supplier";
            this.txtB_supplier.Size = new System.Drawing.Size(100, 20);
            this.txtB_supplier.TabIndex = 6;
            // 
            // txtB_discountS
            // 
            this.txtB_discountS.Location = new System.Drawing.Point(183, 151);
            this.txtB_discountS.Name = "txtB_discountS";
            this.txtB_discountS.Size = new System.Drawing.Size(100, 20);
            this.txtB_discountS.TabIndex = 7;
            // 
            // txtB_discountR
            // 
            this.txtB_discountR.Location = new System.Drawing.Point(183, 120);
            this.txtB_discountR.Name = "txtB_discountR";
            this.txtB_discountR.Size = new System.Drawing.Size(100, 20);
            this.txtB_discountR.TabIndex = 8;
            // 
            // txtB_priceOne
            // 
            this.txtB_priceOne.Location = new System.Drawing.Point(183, 91);
            this.txtB_priceOne.Name = "txtB_priceOne";
            this.txtB_priceOne.Size = new System.Drawing.Size(100, 20);
            this.txtB_priceOne.TabIndex = 9;
            // 
            // txtB_ust
            // 
            this.txtB_ust.Location = new System.Drawing.Point(183, 180);
            this.txtB_ust.Name = "txtB_ust";
            this.txtB_ust.Size = new System.Drawing.Size(100, 20);
            this.txtB_ust.TabIndex = 10;
            // 
            // txtB_info
            // 
            this.txtB_info.Location = new System.Drawing.Point(35, 283);
            this.txtB_info.Multiline = true;
            this.txtB_info.Name = "txtB_info";
            this.txtB_info.Size = new System.Drawing.Size(248, 100);
            this.txtB_info.TabIndex = 11;
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(208, 408);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(75, 23);
            this.bttn_save.TabIndex = 12;
            this.bttn_save.Text = "Speichern";
            this.bttn_save.UseVisualStyleBackColor = true;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // bttn_cancel
            // 
            this.bttn_cancel.Location = new System.Drawing.Point(35, 408);
            this.bttn_cancel.Name = "bttn_cancel";
            this.bttn_cancel.Size = new System.Drawing.Size(75, 23);
            this.bttn_cancel.TabIndex = 13;
            this.bttn_cancel.Text = "Zurück";
            this.bttn_cancel.UseVisualStyleBackColor = true;
            this.bttn_cancel.Click += new System.EventHandler(this.bttn_cancel_Click);
            // 
            // lbl_headline
            // 
            this.lbl_headline.AutoSize = true;
            this.lbl_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headline.Location = new System.Drawing.Point(107, 18);
            this.lbl_headline.Name = "lbl_headline";
            this.lbl_headline.Size = new System.Drawing.Size(90, 24);
            this.lbl_headline.TabIndex = 14;
            this.lbl_headline.Text = "Lieferant";
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.lbl_headline);
            this.Controls.Add(this.bttn_cancel);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.txtB_info);
            this.Controls.Add(this.txtB_ust);
            this.Controls.Add(this.txtB_priceOne);
            this.Controls.Add(this.txtB_discountR);
            this.Controls.Add(this.txtB_discountS);
            this.Controls.Add(this.txtB_supplier);
            this.Controls.Add(this.lbl_ust);
            this.Controls.Add(this.lbl_priceOne);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_discountR);
            this.Controls.Add(this.lbl_discountS);
            this.Controls.Add(this.lbl_supplier);
            this.Name = "supplier";
            this.Text = "supplier";
            this.Load += new System.EventHandler(this.supplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.Label lbl_discountS;
        private System.Windows.Forms.Label lbl_discountR;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Label lbl_priceOne;
        private System.Windows.Forms.Label lbl_ust;
        private System.Windows.Forms.TextBox txtB_supplier;
        private System.Windows.Forms.TextBox txtB_discountS;
        private System.Windows.Forms.TextBox txtB_discountR;
        private System.Windows.Forms.TextBox txtB_priceOne;
        private System.Windows.Forms.TextBox txtB_ust;
        private System.Windows.Forms.TextBox txtB_info;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_cancel;
        private System.Windows.Forms.Label lbl_headline;
    }
}