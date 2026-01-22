namespace SistemSewaMobil.View
{
    partial class FormPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembayaran));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdPembayaran = new System.Windows.Forms.TextBox();
            this.dtPembayaran = new System.Windows.Forms.DateTimePicker();
            this.cmbMetode = new System.Windows.Forms.ComboBox();
            this.txtBiayaServis = new System.Windows.Forms.TextBox();
            this.txtBiayaDiskon = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbStatusPembayaran = new System.Windows.Forms.ComboBox();
            this.lvwPembayaran = new System.Windows.Forms.ListView();
            this.btnHapusPembayaran = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnEditDS = new System.Windows.Forms.Button();
            this.btnTambahPembayaran = new System.Windows.Forms.Button();
            this.cmbNamaPenyewaPB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDDSPB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCariPenyewaDS = new System.Windows.Forms.TextBox();
            this.btnCariPenyewa = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Penyewa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Pembayaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Metode Pembayaran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Biaya Servis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Biaya Diskon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "TOTAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Status Pembayaran";
            // 
            // txtIdPembayaran
            // 
            this.txtIdPembayaran.Location = new System.Drawing.Point(144, 3);
            this.txtIdPembayaran.Name = "txtIdPembayaran";
            this.txtIdPembayaran.Size = new System.Drawing.Size(171, 20);
            this.txtIdPembayaran.TabIndex = 8;
            // 
            // dtPembayaran
            // 
            this.dtPembayaran.Location = new System.Drawing.Point(144, 91);
            this.dtPembayaran.Name = "dtPembayaran";
            this.dtPembayaran.Size = new System.Drawing.Size(171, 20);
            this.dtPembayaran.TabIndex = 10;
            // 
            // cmbMetode
            // 
            this.cmbMetode.FormattingEnabled = true;
            this.cmbMetode.Location = new System.Drawing.Point(144, 124);
            this.cmbMetode.Name = "cmbMetode";
            this.cmbMetode.Size = new System.Drawing.Size(171, 21);
            this.cmbMetode.TabIndex = 11;
            // 
            // txtBiayaServis
            // 
            this.txtBiayaServis.Location = new System.Drawing.Point(144, 157);
            this.txtBiayaServis.Name = "txtBiayaServis";
            this.txtBiayaServis.Size = new System.Drawing.Size(171, 20);
            this.txtBiayaServis.TabIndex = 12;
            this.txtBiayaServis.TextChanged += new System.EventHandler(this.txtBiayaServis_TextChanged);
            // 
            // txtBiayaDiskon
            // 
            this.txtBiayaDiskon.Location = new System.Drawing.Point(144, 189);
            this.txtBiayaDiskon.Name = "txtBiayaDiskon";
            this.txtBiayaDiskon.Size = new System.Drawing.Size(171, 20);
            this.txtBiayaDiskon.TabIndex = 13;
            this.txtBiayaDiskon.TextChanged += new System.EventHandler(this.txtBiayaDiskon_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(144, 221);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(171, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // cmbStatusPembayaran
            // 
            this.cmbStatusPembayaran.FormattingEnabled = true;
            this.cmbStatusPembayaran.Location = new System.Drawing.Point(144, 257);
            this.cmbStatusPembayaran.Name = "cmbStatusPembayaran";
            this.cmbStatusPembayaran.Size = new System.Drawing.Size(171, 21);
            this.cmbStatusPembayaran.TabIndex = 15;
            // 
            // lvwPembayaran
            // 
            this.lvwPembayaran.HideSelection = false;
            this.lvwPembayaran.Location = new System.Drawing.Point(396, 107);
            this.lvwPembayaran.Name = "lvwPembayaran";
            this.lvwPembayaran.Size = new System.Drawing.Size(866, 375);
            this.lvwPembayaran.TabIndex = 16;
            this.lvwPembayaran.UseCompatibleStateImageBehavior = false;
            // 
            // btnHapusPembayaran
            // 
            this.btnHapusPembayaran.Location = new System.Drawing.Point(396, 501);
            this.btnHapusPembayaran.Name = "btnHapusPembayaran";
            this.btnHapusPembayaran.Size = new System.Drawing.Size(133, 37);
            this.btnHapusPembayaran.TabIndex = 18;
            this.btnHapusPembayaran.Text = "Hapus";
            this.btnHapusPembayaran.UseVisualStyleBackColor = true;
            this.btnHapusPembayaran.Click += new System.EventHandler(this.btnHapusPembayaran_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(1129, 501);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(133, 37);
            this.btnSelesai.TabIndex = 19;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnEditDS
            // 
            this.btnEditDS.Location = new System.Drawing.Point(51, 445);
            this.btnEditDS.Name = "btnEditDS";
            this.btnEditDS.Size = new System.Drawing.Size(164, 37);
            this.btnEditDS.TabIndex = 20;
            this.btnEditDS.Text = "Edit Detail Sewa";
            this.btnEditDS.UseVisualStyleBackColor = true;
            this.btnEditDS.Click += new System.EventHandler(this.btnEditDS_Click);
            // 
            // btnTambahPembayaran
            // 
            this.btnTambahPembayaran.Location = new System.Drawing.Point(221, 445);
            this.btnTambahPembayaran.Name = "btnTambahPembayaran";
            this.btnTambahPembayaran.Size = new System.Drawing.Size(148, 37);
            this.btnTambahPembayaran.TabIndex = 22;
            this.btnTambahPembayaran.Text = "Simpan";
            this.btnTambahPembayaran.UseVisualStyleBackColor = true;
            this.btnTambahPembayaran.Click += new System.EventHandler(this.btnTambahPembayaran_Click);
            // 
            // cmbNamaPenyewaPB
            // 
            this.cmbNamaPenyewaPB.FormattingEnabled = true;
            this.cmbNamaPenyewaPB.Location = new System.Drawing.Point(144, 61);
            this.cmbNamaPenyewaPB.Name = "cmbNamaPenyewaPB";
            this.cmbNamaPenyewaPB.Size = new System.Drawing.Size(171, 21);
            this.cmbNamaPenyewaPB.TabIndex = 23;
            this.cmbNamaPenyewaPB.SelectedIndexChanged += new System.EventHandler(this.cmbNamaPenyewaPB_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID Detail Sewa";
            // 
            // txtIDDSPB
            // 
            this.txtIDDSPB.Location = new System.Drawing.Point(144, 31);
            this.txtIDDSPB.Name = "txtIDDSPB";
            this.txtIDDSPB.Size = new System.Drawing.Size(171, 20);
            this.txtIDDSPB.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(393, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Cari Nama Penyewa";
            // 
            // txtCariPenyewaDS
            // 
            this.txtCariPenyewaDS.Location = new System.Drawing.Point(529, 68);
            this.txtCariPenyewaDS.Name = "txtCariPenyewaDS";
            this.txtCariPenyewaDS.Size = new System.Drawing.Size(496, 20);
            this.txtCariPenyewaDS.TabIndex = 27;
            // 
            // btnCariPenyewa
            // 
            this.btnCariPenyewa.Location = new System.Drawing.Point(1044, 69);
            this.btnCariPenyewa.Name = "btnCariPenyewa";
            this.btnCariPenyewa.Size = new System.Drawing.Size(82, 19);
            this.btnCariPenyewa.TabIndex = 28;
            this.btnCariPenyewa.Text = "Cari";
            this.btnCariPenyewa.UseVisualStyleBackColor = true;
            this.btnCariPenyewa.Click += new System.EventHandler(this.btnCariPenyewa_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIdPembayaran, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIDDSPB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbNamaPenyewaPB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtPembayaran, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbMetode, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbStatusPembayaran, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtTotal, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtBiayaServis, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtBiayaDiskon, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 107);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 293);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("DejaVu Sans Mono", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(46, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 30);
            this.label11.TabIndex = 30;
            this.label11.Text = "Form Pembayaran";
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1311, 622);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCariPenyewa);
            this.Controls.Add(this.txtCariPenyewaDS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTambahPembayaran);
            this.Controls.Add(this.btnEditDS);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnHapusPembayaran);
            this.Controls.Add(this.lvwPembayaran);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pembayaran";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdPembayaran;
        private System.Windows.Forms.DateTimePicker dtPembayaran;
        private System.Windows.Forms.ComboBox cmbMetode;
        private System.Windows.Forms.TextBox txtBiayaServis;
        private System.Windows.Forms.TextBox txtBiayaDiskon;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cmbStatusPembayaran;
        private System.Windows.Forms.ListView lvwPembayaran;
        private System.Windows.Forms.Button btnHapusPembayaran;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnEditDS;
        private System.Windows.Forms.Button btnTambahPembayaran;
        private System.Windows.Forms.ComboBox cmbNamaPenyewaPB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDDSPB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCariPenyewaDS;
        private System.Windows.Forms.Button btnCariPenyewa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
    }
}