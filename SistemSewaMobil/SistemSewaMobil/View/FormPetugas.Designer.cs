namespace SistemSewaMobil.View
{
    partial class FormPetugas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPetugas));
            this.btnCariPetugas = new System.Windows.Forms.Button();
            this.txtCariPetugas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvwDaftarPenyewa = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTambahPetugas = new System.Windows.Forms.Button();
            this.btnUpdatePetugas = new System.Windows.Forms.Button();
            this.btnHapusPetugas = new System.Windows.Forms.Button();
            this.btnSelesaiPetugas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCariPetugas
            // 
            this.btnCariPetugas.Location = new System.Drawing.Point(783, 119);
            this.btnCariPetugas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariPetugas.Name = "btnCariPetugas";
            this.btnCariPetugas.Size = new System.Drawing.Size(92, 25);
            this.btnCariPetugas.TabIndex = 33;
            this.btnCariPetugas.Text = "Cari";
            this.btnCariPetugas.UseVisualStyleBackColor = true;
            // 
            // txtCariPetugas
            // 
            this.txtCariPetugas.Location = new System.Drawing.Point(162, 119);
            this.txtCariPetugas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCariPetugas.Name = "txtCariPetugas";
            this.txtCariPetugas.Size = new System.Drawing.Size(613, 22);
            this.txtCariPetugas.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cari data Petugas";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.lvwDaftarPenyewa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 159);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.74374F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.25627F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(853, 458);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // lvwDaftarPenyewa
            // 
            this.lvwDaftarPenyewa.HideSelection = false;
            this.lvwDaftarPenyewa.Location = new System.Drawing.Point(4, 4);
            this.lvwDaftarPenyewa.Margin = new System.Windows.Forms.Padding(4);
            this.lvwDaftarPenyewa.Name = "lvwDaftarPenyewa";
            this.lvwDaftarPenyewa.Size = new System.Drawing.Size(845, 393);
            this.lvwDaftarPenyewa.TabIndex = 0;
            this.lvwDaftarPenyewa.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 484F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 581F));
            this.tableLayoutPanel2.Controls.Add(this.btnTambahPetugas, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdatePetugas, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHapusPetugas, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelesaiPetugas, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 405);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(845, 47);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnTambahPetugas
            // 
            this.btnTambahPetugas.Location = new System.Drawing.Point(4, 4);
            this.btnTambahPetugas.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahPetugas.Name = "btnTambahPetugas";
            this.btnTambahPetugas.Size = new System.Drawing.Size(96, 40);
            this.btnTambahPetugas.TabIndex = 2;
            this.btnTambahPetugas.Text = "Tambah";
            this.btnTambahPetugas.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePetugas
            // 
            this.btnUpdatePetugas.Location = new System.Drawing.Point(116, 4);
            this.btnUpdatePetugas.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePetugas.Name = "btnUpdatePetugas";
            this.btnUpdatePetugas.Size = new System.Drawing.Size(99, 40);
            this.btnUpdatePetugas.TabIndex = 1;
            this.btnUpdatePetugas.Text = "Update";
            this.btnUpdatePetugas.UseVisualStyleBackColor = true;
            // 
            // btnHapusPetugas
            // 
            this.btnHapusPetugas.Location = new System.Drawing.Point(225, 4);
            this.btnHapusPetugas.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusPetugas.Name = "btnHapusPetugas";
            this.btnHapusPetugas.Size = new System.Drawing.Size(100, 40);
            this.btnHapusPetugas.TabIndex = 0;
            this.btnHapusPetugas.Text = "Hapus";
            this.btnHapusPetugas.UseVisualStyleBackColor = true;
            // 
            // btnSelesaiPetugas
            // 
            this.btnSelesaiPetugas.Location = new System.Drawing.Point(709, 4);
            this.btnSelesaiPetugas.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelesaiPetugas.Name = "btnSelesaiPetugas";
            this.btnSelesaiPetugas.Size = new System.Drawing.Size(136, 40);
            this.btnSelesaiPetugas.TabIndex = 3;
            this.btnSelesaiPetugas.Text = "Selesai";
            this.btnSelesaiPetugas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Mono", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "Informasi Petugas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1052, 627);
            this.Controls.Add(this.btnCariPetugas);
            this.Controls.Add(this.txtCariPetugas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "FormPetugas";
            this.Text = "FormPetugas";
            this.Load += new System.EventHandler(this.FormPetugas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCariPetugas;
        private System.Windows.Forms.TextBox txtCariPetugas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvwDaftarPenyewa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnTambahPetugas;
        private System.Windows.Forms.Button btnUpdatePetugas;
        private System.Windows.Forms.Button btnHapusPetugas;
        private System.Windows.Forms.Button btnSelesaiPetugas;
        private System.Windows.Forms.Label label1;
    }
}