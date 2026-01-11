namespace SistemSewaMobil
{
    partial class FormPenyewa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPenyewa));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lvwDaftarPenyewa = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTambahPenyewa = new System.Windows.Forms.Button();
            this.btnUpdatePenyewa = new System.Windows.Forms.Button();
            this.btnHapusPenyewa = new System.Windows.Forms.Button();
            this.btnSelesaiPenyewa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitKeluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMobilTersediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMobilDisewaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPenyewaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPetugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengaturanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keloloaAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panduanPenggunaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tentangAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCariPenyewa = new System.Windows.Forms.TextBox();
            this.btnCariPenyewa = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Mono", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informasi Penyewa";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvwDaftarPenyewa, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 203);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.74374F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.25627F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 443);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lvwDaftarPenyewa
            // 
            this.lvwDaftarPenyewa.HideSelection = false;
            this.lvwDaftarPenyewa.Location = new System.Drawing.Point(4, 4);
            this.lvwDaftarPenyewa.Margin = new System.Windows.Forms.Padding(4);
            this.lvwDaftarPenyewa.Name = "lvwDaftarPenyewa";
            this.lvwDaftarPenyewa.Size = new System.Drawing.Size(841, 379);
            this.lvwDaftarPenyewa.TabIndex = 0;
            this.lvwDaftarPenyewa.UseCompatibleStateImageBehavior = false;
            this.lvwDaftarPenyewa.SelectedIndexChanged += new System.EventHandler(this.infoPenyewa_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.tableLayoutPanel2.Controls.Add(this.btnTambahPenyewa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdatePenyewa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHapusPenyewa, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelesaiPenyewa, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 392);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(841, 47);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnTambahPenyewa
            // 
            this.btnTambahPenyewa.Location = new System.Drawing.Point(4, 4);
            this.btnTambahPenyewa.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahPenyewa.Name = "btnTambahPenyewa";
            this.btnTambahPenyewa.Size = new System.Drawing.Size(96, 40);
            this.btnTambahPenyewa.TabIndex = 2;
            this.btnTambahPenyewa.Text = "Tambah";
            this.btnTambahPenyewa.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePenyewa
            // 
            this.btnUpdatePenyewa.Location = new System.Drawing.Point(116, 4);
            this.btnUpdatePenyewa.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePenyewa.Name = "btnUpdatePenyewa";
            this.btnUpdatePenyewa.Size = new System.Drawing.Size(99, 40);
            this.btnUpdatePenyewa.TabIndex = 1;
            this.btnUpdatePenyewa.Text = "Update";
            this.btnUpdatePenyewa.UseVisualStyleBackColor = true;
            // 
            // btnHapusPenyewa
            // 
            this.btnHapusPenyewa.Location = new System.Drawing.Point(225, 4);
            this.btnHapusPenyewa.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusPenyewa.Name = "btnHapusPenyewa";
            this.btnHapusPenyewa.Size = new System.Drawing.Size(107, 40);
            this.btnHapusPenyewa.TabIndex = 0;
            this.btnHapusPenyewa.Text = "Hapus";
            this.btnHapusPenyewa.UseVisualStyleBackColor = true;
            // 
            // btnSelesaiPenyewa
            // 
            this.btnSelesaiPenyewa.Location = new System.Drawing.Point(710, 4);
            this.btnSelesaiPenyewa.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelesaiPenyewa.Name = "btnSelesaiPenyewa";
            this.btnSelesaiPenyewa.Size = new System.Drawing.Size(131, 40);
            this.btnSelesaiPenyewa.TabIndex = 3;
            this.btnSelesaiPenyewa.Text = "Selesai";
            this.btnSelesaiPenyewa.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterDataToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.pengaturanToolStripMenuItem,
            this.bantuanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(985, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitKeluarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // exitKeluarToolStripMenuItem
            // 
            this.exitKeluarToolStripMenuItem.Name = "exitKeluarToolStripMenuItem";
            this.exitKeluarToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.exitKeluarToolStripMenuItem.Text = "Exit/Keluar";
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMobilToolStripMenuItem,
            this.dataPenyewaToolStripMenuItem,
            this.dataPetugasToolStripMenuItem});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // dataMobilToolStripMenuItem
            // 
            this.dataMobilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMobilTersediaToolStripMenuItem,
            this.dataMobilDisewaToolStripMenuItem1});
            this.dataMobilToolStripMenuItem.Name = "dataMobilToolStripMenuItem";
            this.dataMobilToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.dataMobilToolStripMenuItem.Text = "Data Mobil";
            // 
            // dataMobilTersediaToolStripMenuItem
            // 
            this.dataMobilTersediaToolStripMenuItem.Name = "dataMobilTersediaToolStripMenuItem";
            this.dataMobilTersediaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.dataMobilTersediaToolStripMenuItem.Text = "Data Mobil Tersedia";
            this.dataMobilTersediaToolStripMenuItem.Click += new System.EventHandler(this.dataMobilTersediaToolStripMenuItem_Click_1);
            // 
            // dataMobilDisewaToolStripMenuItem1
            // 
            this.dataMobilDisewaToolStripMenuItem1.Name = "dataMobilDisewaToolStripMenuItem1";
            this.dataMobilDisewaToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.dataMobilDisewaToolStripMenuItem1.Text = "Data Mobil disewa";
            // 
            // dataPenyewaToolStripMenuItem
            // 
            this.dataPenyewaToolStripMenuItem.Name = "dataPenyewaToolStripMenuItem";
            this.dataPenyewaToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.dataPenyewaToolStripMenuItem.Text = "Data Penyewa";
            // 
            // dataPetugasToolStripMenuItem
            // 
            this.dataPetugasToolStripMenuItem.Name = "dataPetugasToolStripMenuItem";
            this.dataPetugasToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.dataPetugasToolStripMenuItem.Text = "Data Petugas";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pembayaranToolStripMenuItem,
            this.printSToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // pembayaranToolStripMenuItem
            // 
            this.pembayaranToolStripMenuItem.Name = "pembayaranToolStripMenuItem";
            this.pembayaranToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.pembayaranToolStripMenuItem.Text = "Pembayaran";
            // 
            // printSToolStripMenuItem
            // 
            this.printSToolStripMenuItem.Name = "printSToolStripMenuItem";
            this.printSToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.printSToolStripMenuItem.Text = "Print Invoice";
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keloloaAkunToolStripMenuItem,
            this.backupDataToolStripMenuItem});
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            // 
            // keloloaAkunToolStripMenuItem
            // 
            this.keloloaAkunToolStripMenuItem.Name = "keloloaAkunToolStripMenuItem";
            this.keloloaAkunToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.keloloaAkunToolStripMenuItem.Text = "Keloloa akun";
            // 
            // backupDataToolStripMenuItem
            // 
            this.backupDataToolStripMenuItem.Name = "backupDataToolStripMenuItem";
            this.backupDataToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.backupDataToolStripMenuItem.Text = "Backup Data";
            // 
            // bantuanToolStripMenuItem
            // 
            this.bantuanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panduanPenggunaanToolStripMenuItem,
            this.tentangAplikasiToolStripMenuItem});
            this.bantuanToolStripMenuItem.Name = "bantuanToolStripMenuItem";
            this.bantuanToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.bantuanToolStripMenuItem.Text = "Bantuan";
            // 
            // panduanPenggunaanToolStripMenuItem
            // 
            this.panduanPenggunaanToolStripMenuItem.Name = "panduanPenggunaanToolStripMenuItem";
            this.panduanPenggunaanToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.panduanPenggunaanToolStripMenuItem.Text = "Panduan Penggunaan";
            // 
            // tentangAplikasiToolStripMenuItem
            // 
            this.tentangAplikasiToolStripMenuItem.Name = "tentangAplikasiToolStripMenuItem";
            this.tentangAplikasiToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.tentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cari data Penyewa";
            // 
            // txtCariPenyewa
            // 
            this.txtCariPenyewa.Location = new System.Drawing.Point(172, 166);
            this.txtCariPenyewa.Margin = new System.Windows.Forms.Padding(4);
            this.txtCariPenyewa.Name = "txtCariPenyewa";
            this.txtCariPenyewa.Size = new System.Drawing.Size(609, 22);
            this.txtCariPenyewa.TabIndex = 27;
            // 
            // btnCariPenyewa
            // 
            this.btnCariPenyewa.Location = new System.Drawing.Point(789, 163);
            this.btnCariPenyewa.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariPenyewa.Name = "btnCariPenyewa";
            this.btnCariPenyewa.Size = new System.Drawing.Size(92, 25);
            this.btnCariPenyewa.TabIndex = 28;
            this.btnCariPenyewa.Text = "Cari";
            this.btnCariPenyewa.UseVisualStyleBackColor = true;
            // 
            // FormPenyewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(985, 659);
            this.Controls.Add(this.btnCariPenyewa);
            this.Controls.Add(this.txtCariPenyewa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPenyewa";
            this.Text = "Penyewa";
            this.Load += new System.EventHandler(this.FormPenyewa_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvwDaftarPenyewa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnHapusPenyewa;
        private System.Windows.Forms.Button btnUpdatePenyewa;
        private System.Windows.Forms.Button btnTambahPenyewa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitKeluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMobilTersediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMobilDisewaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dataPenyewaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPetugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembayaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengaturanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keloloaAkunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantuanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panduanPenggunaanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tentangAplikasiToolStripMenuItem;
        private System.Windows.Forms.Button btnSelesaiPenyewa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCariPenyewa;
        private System.Windows.Forms.Button btnCariPenyewa;
    }
}