namespace quiz
{
    partial class Form1
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
            this.txbSearchKver = new System.Windows.Forms.TextBox();
            this.btnSearchKver = new System.Windows.Forms.Button();
            this.btnResetKver = new System.Windows.Forms.Button();
            this.dgvInformationKver = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformationKver)).BeginInit();
            this.SuspendLayout();
            // 
            // txbSearchKver
            // 
            this.txbSearchKver.Location = new System.Drawing.Point(12, 12);
            this.txbSearchKver.Name = "txbSearchKver";
            this.txbSearchKver.Size = new System.Drawing.Size(100, 20);
            this.txbSearchKver.TabIndex = 0;
            // 
            // btnSearchKver
            // 
            this.btnSearchKver.Location = new System.Drawing.Point(118, 12);
            this.btnSearchKver.Name = "btnSearchKver";
            this.btnSearchKver.Size = new System.Drawing.Size(75, 23);
            this.btnSearchKver.TabIndex = 1;
            this.btnSearchKver.Text = "Search";
            this.btnSearchKver.UseVisualStyleBackColor = true;
            this.btnSearchKver.Click += new System.EventHandler(this.btnSearchKver_Click);
            // 
            // btnResetKver
            // 
            this.btnResetKver.Location = new System.Drawing.Point(199, 12);
            this.btnResetKver.Name = "btnResetKver";
            this.btnResetKver.Size = new System.Drawing.Size(75, 23);
            this.btnResetKver.TabIndex = 1;
            this.btnResetKver.Text = "Reset";
            this.btnResetKver.UseVisualStyleBackColor = true;
            this.btnResetKver.Click += new System.EventHandler(this.btnResetKver_Click);
            // 
            // dgvInformationKver
            // 
            this.dgvInformationKver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformationKver.Location = new System.Drawing.Point(13, 47);
            this.dgvInformationKver.Name = "dgvInformationKver";
            this.dgvInformationKver.Size = new System.Drawing.Size(775, 391);
            this.dgvInformationKver.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInformationKver);
            this.Controls.Add(this.btnResetKver);
            this.Controls.Add(this.btnSearchKver);
            this.Controls.Add(this.txbSearchKver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformationKver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSearchKver;
        private System.Windows.Forms.Button btnSearchKver;
        private System.Windows.Forms.Button btnResetKver;
        private System.Windows.Forms.DataGridView dgvInformationKver;
    }
}

