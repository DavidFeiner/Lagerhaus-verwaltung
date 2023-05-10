namespace Lagerverwaltung
{
    partial class NewProducts
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
            this.lbl_newProduct = new System.Windows.Forms.Label();
            this.lbl_infos = new System.Windows.Forms.Label();
            this.txtB_newProduct = new System.Windows.Forms.TextBox();
            this.txtB_infos = new System.Windows.Forms.TextBox();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_exit = new System.Windows.Forms.Button();
            this.lbl_headline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_newProduct
            // 
            this.lbl_newProduct.AutoSize = true;
            this.lbl_newProduct.Location = new System.Drawing.Point(21, 67);
            this.lbl_newProduct.Name = "lbl_newProduct";
            this.lbl_newProduct.Size = new System.Drawing.Size(79, 13);
            this.lbl_newProduct.TabIndex = 0;
            this.lbl_newProduct.Text = "neues Produkt:";
            // 
            // lbl_infos
            // 
            this.lbl_infos.AutoSize = true;
            this.lbl_infos.Location = new System.Drawing.Point(21, 108);
            this.lbl_infos.Name = "lbl_infos";
            this.lbl_infos.Size = new System.Drawing.Size(124, 13);
            this.lbl_infos.TabIndex = 1;
            this.lbl_infos.Text = "Genauere Informationen:";
            // 
            // txtB_newProduct
            // 
            this.txtB_newProduct.Location = new System.Drawing.Point(188, 64);
            this.txtB_newProduct.Name = "txtB_newProduct";
            this.txtB_newProduct.Size = new System.Drawing.Size(100, 20);
            this.txtB_newProduct.TabIndex = 3;
            // 
            // txtB_infos
            // 
            this.txtB_infos.Location = new System.Drawing.Point(24, 124);
            this.txtB_infos.Multiline = true;
            this.txtB_infos.Name = "txtB_infos";
            this.txtB_infos.Size = new System.Drawing.Size(263, 130);
            this.txtB_infos.TabIndex = 4;
            // 
            // bttn_save
            // 
            this.bttn_save.Location = new System.Drawing.Point(212, 287);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(75, 23);
            this.bttn_save.TabIndex = 5;
            this.bttn_save.Text = "Speichern";
            this.bttn_save.UseVisualStyleBackColor = true;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // bttn_exit
            // 
            this.bttn_exit.Location = new System.Drawing.Point(24, 287);
            this.bttn_exit.Name = "bttn_exit";
            this.bttn_exit.Size = new System.Drawing.Size(75, 23);
            this.bttn_exit.TabIndex = 6;
            this.bttn_exit.Text = "Abbrechen";
            this.bttn_exit.UseVisualStyleBackColor = true;
            this.bttn_exit.Click += new System.EventHandler(this.bttn_exit_Click);
            // 
            // lbl_headline
            // 
            this.lbl_headline.AutoSize = true;
            this.lbl_headline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_headline.Location = new System.Drawing.Point(111, 20);
            this.lbl_headline.Name = "lbl_headline";
            this.lbl_headline.Size = new System.Drawing.Size(81, 24);
            this.lbl_headline.TabIndex = 7;
            this.lbl_headline.Text = "Produkt";
            // 
            // NewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 322);
            this.Controls.Add(this.lbl_headline);
            this.Controls.Add(this.bttn_exit);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.txtB_infos);
            this.Controls.Add(this.txtB_newProduct);
            this.Controls.Add(this.lbl_infos);
            this.Controls.Add(this.lbl_newProduct);
            this.Name = "NewProducts";
            this.Text = "NewProducts";
            this.Load += new System.EventHandler(this.NewProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newProduct;
        private System.Windows.Forms.Label lbl_infos;
        private System.Windows.Forms.TextBox txtB_newProduct;
        private System.Windows.Forms.TextBox txtB_infos;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_exit;
        private System.Windows.Forms.Label lbl_headline;
    }
}