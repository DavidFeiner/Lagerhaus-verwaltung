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
            this.bttn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_back
            // 
            this.bttn_back.Location = new System.Drawing.Point(522, 387);
            this.bttn_back.Margin = new System.Windows.Forms.Padding(2);
            this.bttn_back.Name = "bttn_back";
            this.bttn_back.Size = new System.Drawing.Size(118, 38);
            this.bttn_back.TabIndex = 6;
            this.bttn_back.Text = "zurück";
            this.bttn_back.UseVisualStyleBackColor = true;
            this.bttn_back.Click += new System.EventHandler(this.bttn_back_Click);
            // 
            // sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.bttn_back);
            this.Name = "sell";
            this.Text = "sell";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_back;
    }
}