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
            this.lvwDaftarPetugas = new System.Windows.Forms.ListView();
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
            this.btnCariPetugas.Location = new System.Drawing.Point(587, 97);
            this.btnCariPetugas.Name = "btnCariPetugas";
            this.btnCariPetugas.Size = new System.Drawing.Size(69, 20);
            this.btnCariPetugas.TabIndex = 33;
            this.btnCariPetugas.Text = "Cari";
            this.btnCariPetugas.UseVisualStyleBackColor = true;
            this.btnCariPetugas.Click += new System.EventHandler(this.btnCariPetugas_Click);
            // 
            // txtCariPetugas
            // 
            this.txtCariPetugas.Location = new System.Drawing.Point(122, 97);
            this.txtCariPetugas.Name = "txtCariPetugas";
            this.txtCariPetugas.Size = new System.Drawing.Size(461, 20);
            this.txtCariPetugas.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cari data Petugas";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lvwDaftarPetugas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 129);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.74374F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.25627F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 372);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // lvwDaftarPetugas
            // 
            this.lvwDaftarPetugas.HideSelection = false;
            this.lvwDaftarPetugas.Location = new System.Drawing.Point(3, 3);
            this.lvwDaftarPetugas.Name = "lvwDaftarPetugas";
            this.lvwDaftarPetugas.Size = new System.Drawing.Size(634, 320);
            this.lvwDaftarPetugas.TabIndex = 0;
            this.lvwDaftarPetugas.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 363F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 436F));
            this.tableLayoutPanel2.Controls.Add(this.btnTambahPetugas, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdatePetugas, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHapusPetugas, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelesaiPetugas, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 329);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(634, 38);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnTambahPetugas
            // 
            this.btnTambahPetugas.Location = new System.Drawing.Point(3, 3);
            this.btnTambahPetugas.Name = "btnTambahPetugas";
            this.btnTambahPetugas.Size = new System.Drawing.Size(72, 32);
            this.btnTambahPetugas.TabIndex = 2;
            this.btnTambahPetugas.Text = "Tambah";
            this.btnTambahPetugas.UseVisualStyleBackColor = true;
            this.btnTambahPetugas.Click += new System.EventHandler(this.btnTambahPetugas_Click);
            // 
            // btnUpdatePetugas
            // 
            this.btnUpdatePetugas.Location = new System.Drawing.Point(87, 3);
            this.btnUpdatePetugas.Name = "btnUpdatePetugas";
            this.btnUpdatePetugas.Size = new System.Drawing.Size(74, 32);
            this.btnUpdatePetugas.TabIndex = 1;
            this.btnUpdatePetugas.Text = "Update";
            this.btnUpdatePetugas.UseVisualStyleBackColor = true;
            this.btnUpdatePetugas.Click += new System.EventHandler(this.btnUpdatePetugas_Click);
            // 
            // btnHapusPetugas
            // 
            this.btnHapusPetugas.Location = new System.Drawing.Point(169, 3);
            this.btnHapusPetugas.Name = "btnHapusPetugas";
            this.btnHapusPetugas.Size = new System.Drawing.Size(75, 32);
            this.btnHapusPetugas.TabIndex = 0;
            this.btnHapusPetugas.Text = "Hapus";
            this.btnHapusPetugas.UseVisualStyleBackColor = true;
            this.btnHapusPetugas.Click += new System.EventHandler(this.btnHapusPetugas_Click);
            // 
            // btnSelesaiPetugas
            // 
            this.btnSelesaiPetugas.Location = new System.Drawing.Point(532, 3);
            this.btnSelesaiPetugas.Name = "btnSelesaiPetugas";
            this.btnSelesaiPetugas.Size = new System.Drawing.Size(102, 32);
            this.btnSelesaiPetugas.TabIndex = 3;
            this.btnSelesaiPetugas.Text = "Selesai";
            this.btnSelesaiPetugas.UseVisualStyleBackColor = true;
            this.btnSelesaiPetugas.Click += new System.EventHandler(this.btnSelesaiPetugas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Mono", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Informasi Petugas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(789, 509);
            this.Controls.Add(this.btnCariPetugas);
            this.Controls.Add(this.txtCariPetugas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ListView lvwDaftarPetugas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnTambahPetugas;
        private System.Windows.Forms.Button btnUpdatePetugas;
        private System.Windows.Forms.Button btnHapusPetugas;
        private System.Windows.Forms.Button btnSelesaiPetugas;
        private System.Windows.Forms.Label label1;
    }
}