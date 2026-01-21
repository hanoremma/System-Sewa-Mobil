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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembayaran));
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnHapusPembayaran = new System.Windows.Forms.Button();
            this.lvwPembayaran = new System.Windows.Forms.ListView();
            this.btnCariPenyewa = new System.Windows.Forms.Button();
            this.txtCariPenyewaDS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBeranda = new System.Windows.Forms.Button();
            this.btnPenyewa = new System.Windows.Forms.Button();
            this.btnPembayaran = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
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
            this.btnEditDS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTambahPembayaran = new System.Windows.Forms.Button();
            this.cmbNamaPenyewaPB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDDSPB = new System.Windows.Forms.TextBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(1306, 525);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(133, 37);
            this.btnSelesai.TabIndex = 43;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnHapusPembayaran
            // 
            this.btnHapusPembayaran.Location = new System.Drawing.Point(493, 525);
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
            this.lvwPembayaran.Location = new System.Drawing.Point(493, 132);
            this.lvwPembayaran.Name = "lvwPembayaran";
            this.lvwPembayaran.Size = new System.Drawing.Size(946, 375);
            this.lvwPembayaran.TabIndex = 41;
            this.lvwPembayaran.UseCompatibleStateImageBehavior = false;
            this.lvwPembayaran.SelectedIndexChanged += new System.EventHandler(this.lvwPembayaran_SelectedIndexChanged);
            // 
            // btnCariPenyewa
            // 
            this.btnCariPenyewa.Location = new System.Drawing.Point(1370, 96);
            this.btnCariPenyewa.Name = "btnCariPenyewa";
            this.btnCariPenyewa.Size = new System.Drawing.Size(69, 20);
            this.btnCariPenyewa.TabIndex = 53;
            this.btnCariPenyewa.Text = "Cari";
            this.btnCariPenyewa.UseVisualStyleBackColor = true;
            this.btnCariPenyewa.Click += new System.EventHandler(this.btnCariPenyewa_Click);
            // 
            // txtCariPenyewaDS
            // 
            this.txtCariPenyewaDS.Location = new System.Drawing.Point(621, 97);
            this.txtCariPenyewaDS.Name = "txtCariPenyewaDS";
            this.txtCariPenyewaDS.Size = new System.Drawing.Size(743, 20);
            this.txtCariPenyewaDS.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(490, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Cari data Penyewa";
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.sidebar.Controls.Add(this.menuButton);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btnPenyewa);
            this.sidebar.Controls.Add(this.btnPembayaran);
            this.sidebar.Controls.Add(this.btnExit);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(285, 631);
            this.sidebar.MinimumSize = new System.Drawing.Size(115, 631);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(115, 631);
            this.sidebar.TabIndex = 54;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.ForeColor = System.Drawing.Color.Transparent;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.Location = new System.Drawing.Point(3, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.menuButton.Size = new System.Drawing.Size(279, 134);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "                Menu\n";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnBeranda);
            this.panel1.Location = new System.Drawing.Point(3, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 88);
            this.panel1.TabIndex = 0;
            // 
            // btnBeranda
            // 
            this.btnBeranda.FlatAppearance.BorderSize = 0;
            this.btnBeranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeranda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeranda.ForeColor = System.Drawing.Color.Transparent;
            this.btnBeranda.Image = ((System.Drawing.Image)(resources.GetObject("btnBeranda.Image")));
            this.btnBeranda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeranda.Location = new System.Drawing.Point(0, 5);
            this.btnBeranda.Name = "btnBeranda";
            this.btnBeranda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBeranda.Size = new System.Drawing.Size(279, 83);
            this.btnBeranda.TabIndex = 10;
            this.btnBeranda.Text = "                Beranda";
            this.btnBeranda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeranda.UseVisualStyleBackColor = true;
            this.btnBeranda.Click += new System.EventHandler(this.btnBeranda_Click);
            // 
            // btnPenyewa
            // 
            this.btnPenyewa.FlatAppearance.BorderSize = 0;
            this.btnPenyewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenyewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenyewa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPenyewa.Image = ((System.Drawing.Image)(resources.GetObject("btnPenyewa.Image")));
            this.btnPenyewa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenyewa.Location = new System.Drawing.Point(3, 237);
            this.btnPenyewa.Name = "btnPenyewa";
            this.btnPenyewa.Size = new System.Drawing.Size(279, 83);
            this.btnPenyewa.TabIndex = 6;
            this.btnPenyewa.Text = "                  Penyewaan\r\n";
            this.btnPenyewa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenyewa.UseVisualStyleBackColor = true;
            this.btnPenyewa.Click += new System.EventHandler(this.btnPenyewa_Click);
            // 
            // btnPembayaran
            // 
            this.btnPembayaran.FlatAppearance.BorderSize = 0;
            this.btnPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembayaran.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPembayaran.Image = ((System.Drawing.Image)(resources.GetObject("btnPembayaran.Image")));
            this.btnPembayaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPembayaran.Location = new System.Drawing.Point(3, 326);
            this.btnPembayaran.Name = "btnPembayaran";
            this.btnPembayaran.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPembayaran.Size = new System.Drawing.Size(279, 83);
            this.btnPembayaran.TabIndex = 7;
            this.btnPembayaran.Text = "                Pembayaran\r\n";
            this.btnPembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPembayaran.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(3, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(279, 83);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "                Keluar\r\n";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(161, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nama Penyewa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(159, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID Pembayaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(159, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tanggal Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(159, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Metode Pembayaran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(159, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Biaya Servis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(161, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Biaya Diskon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(161, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "TOTAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(159, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Status Pembayaran";
            // 
            // txtIdPembayaran
            // 
            this.txtIdPembayaran.Location = new System.Drawing.Point(277, 132);
            this.txtIdPembayaran.Name = "txtIdPembayaran";
            this.txtIdPembayaran.Size = new System.Drawing.Size(187, 20);
            this.txtIdPembayaran.TabIndex = 34;
            // 
            // dtPembayaran
            // 
            this.dtPembayaran.Location = new System.Drawing.Point(279, 239);
            this.dtPembayaran.Name = "dtPembayaran";
            this.dtPembayaran.Size = new System.Drawing.Size(184, 20);
            this.dtPembayaran.TabIndex = 35;
            // 
            // cmbMetode
            // 
            this.cmbMetode.FormattingEnabled = true;
            this.cmbMetode.Location = new System.Drawing.Point(277, 279);
            this.cmbMetode.Name = "cmbMetode";
            this.cmbMetode.Size = new System.Drawing.Size(186, 21);
            this.cmbMetode.TabIndex = 36;
            // 
            // txtBiayaServis
            // 
            this.txtBiayaServis.Location = new System.Drawing.Point(277, 316);
            this.txtBiayaServis.Name = "txtBiayaServis";
            this.txtBiayaServis.Size = new System.Drawing.Size(187, 20);
            this.txtBiayaServis.TabIndex = 37;
            this.txtBiayaServis.TextChanged += new System.EventHandler(this.txtBiayaServis_TextChanged);
            // 
            // txtBiayaDiskon
            // 
            this.txtBiayaDiskon.Location = new System.Drawing.Point(277, 353);
            this.txtBiayaDiskon.Name = "txtBiayaDiskon";
            this.txtBiayaDiskon.Size = new System.Drawing.Size(187, 20);
            this.txtBiayaDiskon.TabIndex = 38;
            this.txtBiayaDiskon.TextChanged += new System.EventHandler(this.txtBiayaDiskon_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(277, 396);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(187, 20);
            this.txtTotal.TabIndex = 39;
            // 
            // cmbStatusPembayaran
            // 
            this.cmbStatusPembayaran.FormattingEnabled = true;
            this.cmbStatusPembayaran.Location = new System.Drawing.Point(277, 437);
            this.cmbStatusPembayaran.Name = "cmbStatusPembayaran";
            this.cmbStatusPembayaran.Size = new System.Drawing.Size(186, 21);
            this.cmbStatusPembayaran.TabIndex = 40;
            // 
            // btnEditDS
            // 
            this.btnEditDS.Location = new System.Drawing.Point(152, 484);
            this.btnEditDS.Name = "btnEditDS";
            this.btnEditDS.Size = new System.Drawing.Size(133, 37);
            this.btnEditDS.TabIndex = 44;
            this.btnEditDS.Text = "Edit Detail Sewa";
            this.btnEditDS.UseVisualStyleBackColor = true;
            this.btnEditDS.Click += new System.EventHandler(this.btnEditDS_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(161, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "ID Detail Sewa";
            // 
            // btnTambahPembayaran
            // 
            this.btnTambahPembayaran.Location = new System.Drawing.Point(332, 484);
            this.btnTambahPembayaran.Name = "btnTambahPembayaran";
            this.btnTambahPembayaran.Size = new System.Drawing.Size(133, 37);
            this.btnTambahPembayaran.TabIndex = 46;
            this.btnTambahPembayaran.Text = "Simpan";
            this.btnTambahPembayaran.UseVisualStyleBackColor = true;
            this.btnTambahPembayaran.Click += new System.EventHandler(this.btnTambahPembayaran_Click);
            // 
            // cmbNamaPenyewaPB
            // 
            this.cmbNamaPenyewaPB.FormattingEnabled = true;
            this.cmbNamaPenyewaPB.Location = new System.Drawing.Point(277, 202);
            this.cmbNamaPenyewaPB.Name = "cmbNamaPenyewaPB";
            this.cmbNamaPenyewaPB.Size = new System.Drawing.Size(186, 21);
            this.cmbNamaPenyewaPB.TabIndex = 47;
            this.cmbNamaPenyewaPB.SelectedIndexChanged += new System.EventHandler(this.cmbNamaPenyewaPB_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(156, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 46);
            this.label10.TabIndex = 50;
            this.label10.Text = "Pembayaran";
            // 
            // txtIDDSPB
            // 
            this.txtIDDSPB.Location = new System.Drawing.Point(278, 167);
            this.txtIDDSPB.Name = "txtIDDSPB";
            this.txtIDDSPB.Size = new System.Drawing.Size(187, 20);
            this.txtIDDSPB.TabIndex = 49;
            // 
            // FormPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1451, 576);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.btnCariPenyewa);
            this.Controls.Add(this.txtCariPenyewaDS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIDDSPB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbNamaPenyewaPB);
            this.Controls.Add(this.btnTambahPembayaran);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPembayaran";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnHapusPembayaran;
        private System.Windows.Forms.ListView lvwPembayaran;
        private System.Windows.Forms.Button btnCariPenyewa;
        private System.Windows.Forms.TextBox txtCariPenyewaDS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBeranda;
        private System.Windows.Forms.Button btnPenyewa;
        private System.Windows.Forms.Button btnPembayaran;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer sidebarTimer;
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
        private System.Windows.Forms.Button btnEditDS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTambahPembayaran;
        private System.Windows.Forms.ComboBox cmbNamaPenyewaPB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDDSPB;
    }
}