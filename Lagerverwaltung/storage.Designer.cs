namespace Lagerverwaltung
{
    partial class storage
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
            this.lbl_storage = new System.Windows.Forms.Label();
            this.dgv_storage = new System.Windows.Forms.DataGridView();
            this.bttn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_storage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_storage
            // 
            this.lbl_storage.AutoSize = true;
            this.lbl_storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storage.Location = new System.Drawing.Point(12, 20);
            this.lbl_storage.Name = "lbl_storage";
            this.lbl_storage.Size = new System.Drawing.Size(83, 31);
            this.lbl_storage.TabIndex = 8;
            this.lbl_storage.Text = "Lager";
            // 
            // dgv_storage
            // 
            this.dgv_storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_storage.Location = new System.Drawing.Point(12, 67);
            this.dgv_storage.Name = "dgv_storage";
            this.dgv_storage.Size = new System.Drawing.Size(613, 356);
            this.dgv_storage.TabIndex = 9;
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(550, 30);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(75, 23);
            this.bttn_back.TabIndex = 10;
            this.bttn_back.Text = "zurück";
            this.bttn_back.UseVisualStyleBackColor = true;
            // 
            // storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.bttn_back);
            this.Controls.Add(this.dgv_storage);
            this.Controls.Add(this.lbl_storage);
            this.Name = "storage";
            this.Text = "storage";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_storage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_storage;
        private System.Windows.Forms.DataGridView dgv_storage;
        private System.Windows.Forms.Button bttn_back;
    }
}