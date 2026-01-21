namespace SistemSewaMobil.View
{
    partial class FormLaporan
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
            this.lvwLaporan = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwLaporan
            // 
            this.lvwLaporan.HideSelection = false;
            this.lvwLaporan.Location = new System.Drawing.Point(21, 77);
            this.lvwLaporan.Name = "lvwLaporan";
            this.lvwLaporan.Size = new System.Drawing.Size(1299, 490);
            this.lvwLaporan.TabIndex = 0;
            this.lvwLaporan.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(77, 619);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(215, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(1180, 614);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(140, 37);
            this.btnSelesai.TabIndex = 3;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Mono", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Riwayat Penyewaan";
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 678);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwLaporan);
            this.Name = "FormLaporan";
            this.Text = "FormLaporan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwLaporan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Label label2;
    }
}