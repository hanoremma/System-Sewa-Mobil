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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.infoPenyewa = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Mono", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informasi Penyewa";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.infoPenyewa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.74374F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.25627F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 360);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // infoPenyewa
            // 
            this.infoPenyewa.HideSelection = false;
            this.infoPenyewa.Location = new System.Drawing.Point(3, 3);
            this.infoPenyewa.Name = "infoPenyewa";
            this.infoPenyewa.Size = new System.Drawing.Size(846, 309);
            this.infoPenyewa.TabIndex = 0;
            this.infoPenyewa.UseCompatibleStateImageBehavior = false;
            this.infoPenyewa.SelectedIndexChanged += new System.EventHandler(this.infoPenyewa_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 597F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 318);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(846, 38);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hapus";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tambah";
            this.button3.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // exitKeluarToolStripMenuItem
            // 
            this.exitKeluarToolStripMenuItem.Name = "exitKeluarToolStripMenuItem";
            this.exitKeluarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitKeluarToolStripMenuItem.Text = "Exit/Keluar";
            // 
            // masterDataToolStripMenuItem
            // 
            this.masterDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMobilToolStripMenuItem,
            this.dataPenyewaToolStripMenuItem,
            this.dataPetugasToolStripMenuItem});
            this.masterDataToolStripMenuItem.Name = "masterDataToolStripMenuItem";
            this.masterDataToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.masterDataToolStripMenuItem.Text = "Master Data";
            // 
            // dataMobilToolStripMenuItem
            // 
            this.dataMobilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMobilTersediaToolStripMenuItem,
            this.dataMobilDisewaToolStripMenuItem1});
            this.dataMobilToolStripMenuItem.Name = "dataMobilToolStripMenuItem";
            this.dataMobilToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dataMobilToolStripMenuItem.Text = "Data Mobil";
            // 
            // dataMobilTersediaToolStripMenuItem
            // 
            this.dataMobilTersediaToolStripMenuItem.Name = "dataMobilTersediaToolStripMenuItem";
            this.dataMobilTersediaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.dataMobilTersediaToolStripMenuItem.Text = "Data Mobil Tersedia";
            this.dataMobilTersediaToolStripMenuItem.Click += new System.EventHandler(this.dataMobilTersediaToolStripMenuItem_Click_1);
            // 
            // dataMobilDisewaToolStripMenuItem1
            // 
            this.dataMobilDisewaToolStripMenuItem1.Name = "dataMobilDisewaToolStripMenuItem1";
            this.dataMobilDisewaToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.dataMobilDisewaToolStripMenuItem1.Text = "Data Mobil disewa";
            // 
            // dataPenyewaToolStripMenuItem
            // 
            this.dataPenyewaToolStripMenuItem.Name = "dataPenyewaToolStripMenuItem";
            this.dataPenyewaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dataPenyewaToolStripMenuItem.Text = "Data Penyewa";
            // 
            // dataPetugasToolStripMenuItem
            // 
            this.dataPetugasToolStripMenuItem.Name = "dataPetugasToolStripMenuItem";
            this.dataPetugasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.dataPetugasToolStripMenuItem.Text = "Data Petugas";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pembayaranToolStripMenuItem,
            this.printSToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // pembayaranToolStripMenuItem
            // 
            this.pembayaranToolStripMenuItem.Name = "pembayaranToolStripMenuItem";
            this.pembayaranToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pembayaranToolStripMenuItem.Text = "Pembayaran";
            // 
            // printSToolStripMenuItem
            // 
            this.printSToolStripMenuItem.Name = "printSToolStripMenuItem";
            this.printSToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printSToolStripMenuItem.Text = "Print Invoice";
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keloloaAkunToolStripMenuItem,
            this.backupDataToolStripMenuItem});
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            // 
            // keloloaAkunToolStripMenuItem
            // 
            this.keloloaAkunToolStripMenuItem.Name = "keloloaAkunToolStripMenuItem";
            this.keloloaAkunToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.keloloaAkunToolStripMenuItem.Text = "Keloloa akun";
            // 
            // backupDataToolStripMenuItem
            // 
            this.backupDataToolStripMenuItem.Name = "backupDataToolStripMenuItem";
            this.backupDataToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.backupDataToolStripMenuItem.Text = "Backup Data";
            // 
            // bantuanToolStripMenuItem
            // 
            this.bantuanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panduanPenggunaanToolStripMenuItem,
            this.tentangAplikasiToolStripMenuItem});
            this.bantuanToolStripMenuItem.Name = "bantuanToolStripMenuItem";
            this.bantuanToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bantuanToolStripMenuItem.Text = "Bantuan";
            // 
            // panduanPenggunaanToolStripMenuItem
            // 
            this.panduanPenggunaanToolStripMenuItem.Name = "panduanPenggunaanToolStripMenuItem";
            this.panduanPenggunaanToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.panduanPenggunaanToolStripMenuItem.Text = "Panduan Penggunaan";
            // 
            // tentangAplikasiToolStripMenuItem
            // 
            this.tentangAplikasiToolStripMenuItem.Name = "tentangAplikasiToolStripMenuItem";
            this.tentangAplikasiToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.tentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(766, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Selesai";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cari data Penyewa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(672, 20);
            this.textBox1.TabIndex = 27;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(795, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 20);
            this.button5.TabIndex = 28;
            this.button5.Text = "Cari";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FormPenyewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 509);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ListView infoPenyewa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
    }
}