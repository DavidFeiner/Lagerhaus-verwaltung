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
            this.dgv_storage = new System.Windows.Forms.DataGridView();
            this.bttn_back = new System.Windows.Forms.Button();
            this.lbl_storage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_storage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_storage
            // 
            this.dgv_storage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_storage.Location = new System.Drawing.Point(12, 68);
            this.dgv_storage.Name = "dgv_storage";
            this.dgv_storage.Size = new System.Drawing.Size(613, 301);
            this.dgv_storage.TabIndex = 9;
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(550, 378);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(75, 23);
            this.bttn_back.TabIndex = 10;
            this.bttn_back.Text = "zurück";
            this.bttn_back.UseVisualStyleBackColor = true;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click_1);
            // 
            // lbl_storage
            // 
            this.lbl_storage.AutoSize = true;
            this.lbl_storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storage.Location = new System.Drawing.Point(12, 30);
            this.lbl_storage.Name = "lbl_storage";
            this.lbl_storage.Size = new System.Drawing.Size(63, 24);
            this.lbl_storage.TabIndex = 11;
            this.lbl_storage.Text = "Lager";
            // 
            // storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 413);
            this.Controls.Add(this.lbl_storage);
            this.Controls.Add(this.bttn_back);
            this.Controls.Add(this.dgv_storage);
            this.Name = "storage";
            this.Text = "storage";
            this.Load += new System.EventHandler(this.storage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_storage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_storage;
        private System.Windows.Forms.Button bttn_back;
        private System.Windows.Forms.Label lbl_storage;
    }
}