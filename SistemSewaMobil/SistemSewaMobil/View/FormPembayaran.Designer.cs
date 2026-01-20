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
            this.txtIDDSPB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNamaPenyewaPB = new System.Windows.Forms.ComboBox();
            this.btnTambahPembayaran = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnEditDS = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnHapusPembayaran = new System.Windows.Forms.Button();
            this.lvwPembayaran = new System.Windows.Forms.ListView();
            this.cmbStatusPembayaran = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtBiayaDiskon = new System.Windows.Forms.TextBox();
            this.txtBiayaServis = new System.Windows.Forms.TextBox();
            this.cmbMetode = new System.Windows.Forms.ComboBox();
            this.dtPembayaran = new System.Windows.Forms.DateTimePicker();
            this.txtIdPembayaran = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCariPenyewa = new System.Windows.Forms.Button();
            this.txtCariPenyewaDS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIDDSPB
            // 
            this.txtIDDSPB.Location = new System.Drawing.Point(165, 165);
            this.txtIDDSPB.Name = "txtIDDSPB";
            this.txtIDDSPB.Size = new System.Drawing.Size(187, 20);
            this.txtIDDSPB.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "ID Detail Sewa";
            // 
            // cmbNamaPenyewaPB
            // 
            this.cmbNamaPenyewaPB.FormattingEnabled = true;
            this.cmbNamaPenyewaPB.Location = new System.Drawing.Point(164, 200);
            this.cmbNamaPenyewaPB.Name = "cmbNamaPenyewaPB";
            this.cmbNamaPenyewaPB.Size = new System.Drawing.Size(186, 21);
            this.cmbNamaPenyewaPB.TabIndex = 47;
            this.cmbNamaPenyewaPB.SelectedIndexChanged += new System.EventHandler(this.cmbNamaPenyewaPB_SelectedIndexChanged);
            // 
            // btnTambahPembayaran
            // 
            this.btnTambahPembayaran.Location = new System.Drawing.Point(219, 482);
            this.btnTambahPembayaran.Name = "btnTambahPembayaran";
            this.btnTambahPembayaran.Size = new System.Drawing.Size(133, 37);
            this.btnTambahPembayaran.TabIndex = 46;
            this.btnTambahPembayaran.Text = "Simpan";
            this.btnTambahPembayaran.UseVisualStyleBackColor = true;
            this.btnTambahPembayaran.Click += new System.EventHandler(this.btnTambahPembayaran_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(33, 619);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 37);
            this.button5.TabIndex = 45;
            this.button5.Text = "Beranda Penyewaan";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnEditDS
            // 
            this.btnEditDS.Location = new System.Drawing.Point(33, 576);
            this.btnEditDS.Name = "btnEditDS";
            this.btnEditDS.Size = new System.Drawing.Size(133, 37);
            this.btnEditDS.TabIndex = 44;
            this.btnEditDS.Text = "Edit Detail Sewa";
            this.btnEditDS.UseVisualStyleBackColor = true;
            this.btnEditDS.Click += new System.EventHandler(this.btnEditDS_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(1227, 523);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(133, 37);
            this.btnSelesai.TabIndex = 43;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnHapusPembayaran
            // 
            this.btnHapusPembayaran.Location = new System.Drawing.Point(414, 523);
            this.btnHapusPembayaran.Name = "btnHapusPembayaran";
            this.btnHapusPembayaran.Size = new System.Drawing.Size(133, 37);
            this.btnHapusPembayaran.TabIndex = 42;
            this.btnHapusPembayaran.Text = "Hapus";
            this.btnHapusPembayaran.UseVisualStyleBackColor = true;
            this.btnHapusPembayaran.Click += new System.EventHandler(this.btnHapusPembayaran_Click);
            // 
            // lvwPembayaran
            // 
            this.lvwPembayaran.HideSelection = false;
            this.lvwPembayaran.Location = new System.Drawing.Point(414, 130);
            this.lvwPembayaran.Name = "lvwPembayaran";
            this.lvwPembayaran.Size = new System.Drawing.Size(946, 375);
            this.lvwPembayaran.TabIndex = 41;
            this.lvwPembayaran.UseCompatibleStateImageBehavior = false;
            this.lvwPembayaran.SelectedIndexChanged += new System.EventHandler(this.lvwPembayaran_SelectedIndexChanged);
            // 
            // cmbStatusPembayaran
            // 
            this.cmbStatusPembayaran.FormattingEnabled = true;
            this.cmbStatusPembayaran.Location = new System.Drawing.Point(166, 435);
            this.cmbStatusPembayaran.Name = "cmbStatusPembayaran";
            this.cmbStatusPembayaran.Size = new System.Drawing.Size(186, 21);
            this.cmbStatusPembayaran.TabIndex = 40;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(164, 394);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(187, 20);
            this.txtTotal.TabIndex = 39;
            // 
            // txtBiayaDiskon
            // 
            this.txtBiayaDiskon.Location = new System.Drawing.Point(164, 351);
            this.txtBiayaDiskon.Name = "txtBiayaDiskon";
            this.txtBiayaDiskon.Size = new System.Drawing.Size(187, 20);
            this.txtBiayaDiskon.TabIndex = 38;
            this.txtBiayaDiskon.TextChanged += new System.EventHandler(this.txtBiayaDiskon_TextChanged);
            // 
            // txtBiayaServis
            // 
            this.txtBiayaServis.Location = new System.Drawing.Point(164, 314);
            this.txtBiayaServis.Name = "txtBiayaServis";
            this.txtBiayaServis.Size = new System.Drawing.Size(187, 20);
            this.txtBiayaServis.TabIndex = 37;
            this.txtBiayaServis.TextChanged += new System.EventHandler(this.txtBiayaServis_TextChanged);
            // 
            // cmbMetode
            // 
            this.cmbMetode.FormattingEnabled = true;
            this.cmbMetode.Location = new System.Drawing.Point(164, 277);
            this.cmbMetode.Name = "cmbMetode";
            this.cmbMetode.Size = new System.Drawing.Size(186, 21);
            this.cmbMetode.TabIndex = 36;
            // 
            // dtPembayaran
            // 
            this.dtPembayaran.Location = new System.Drawing.Point(166, 237);
            this.dtPembayaran.Name = "dtPembayaran";
            this.dtPembayaran.Size = new System.Drawing.Size(184, 20);
            this.dtPembayaran.TabIndex = 35;
            // 
            // txtIdPembayaran
            // 
            this.txtIdPembayaran.Location = new System.Drawing.Point(164, 130);
            this.txtIdPembayaran.Name = "txtIdPembayaran";
            this.txtIdPembayaran.Size = new System.Drawing.Size(187, 20);
            this.txtIdPembayaran.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Status Pembayaran";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Biaya Diskon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Biaya Servis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Metode Pembayaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tanggal Pembayaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID Pembayaran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nama Penyewa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("DejaVu Sans Mono", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(44, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 30);
            this.label10.TabIndex = 50;
            this.label10.Text = "Pembayaran";
            // 
            // btnCariPenyewa
            // 
            this.btnCariPenyewa.Location = new System.Drawing.Point(1291, 94);
            this.btnCariPenyewa.Name = "btnCariPenyewa";
            this.btnCariPenyewa.Size = new System.Drawing.Size(69, 20);
            this.btnCariPenyewa.TabIndex = 53;
            this.btnCariPenyewa.Text = "Cari";
            this.btnCariPenyewa.UseVisualStyleBackColor = true;
            this.btnCariPenyewa.Click += new System.EventHandler(this.btnCariPenyewa_Click);
            // 
            // txtCariPenyewaDS
            // 
            this.txtCariPenyewaDS.Location = new System.Drawing.Point(542, 95);
            this.txtCariPenyewaDS.Name = "txtCariPenyewaDS";
            this.txtCariPenyewaDS.Size = new System.Drawing.Size(743, 20);
            this.txtCariPenyewaDS.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(411, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Cari data Penyewa";
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 687);
            this.Controls.Add(this.btnCariPenyewa);
            this.Controls.Add(this.txtCariPenyewaDS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIDDSPB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbNamaPenyewaPB);
            this.Controls.Add(this.btnTambahPembayaran);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnEditDS);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnHapusPembayaran);
            this.Controls.Add(this.lvwPembayaran);
            this.Controls.Add(this.cmbStatusPembayaran);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtBiayaDiskon);
            this.Controls.Add(this.txtBiayaServis);
            this.Controls.Add(this.cmbMetode);
            this.Controls.Add(this.dtPembayaran);
            this.Controls.Add(this.txtIdPembayaran);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPembayaran";
            this.Text = "FormPembayaran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDDSPB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNamaPenyewaPB;
        private System.Windows.Forms.Button btnTambahPembayaran;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnEditDS;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnHapusPembayaran;
        private System.Windows.Forms.ListView lvwPembayaran;
        private System.Windows.Forms.ComboBox cmbStatusPembayaran;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtBiayaDiskon;
        private System.Windows.Forms.TextBox txtBiayaServis;
        private System.Windows.Forms.ComboBox cmbMetode;
        private System.Windows.Forms.DateTimePicker dtPembayaran;
        private System.Windows.Forms.TextBox txtIdPembayaran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCariPenyewa;
        private System.Windows.Forms.TextBox txtCariPenyewaDS;
        private System.Windows.Forms.Label label11;
    }
}