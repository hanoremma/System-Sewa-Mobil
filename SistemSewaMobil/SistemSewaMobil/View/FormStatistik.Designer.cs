namespace SistemSewaMobil.View
{
    partial class FormStatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistik));
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPenyewa = new System.Windows.Forms.Button();
            this.btnMobil = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnPetugas = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBeranda = new System.Windows.Forms.Button();
            this.btnPenyewaan = new System.Windows.Forms.Button();
            this.btnPembayaran = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(331, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 152);
            this.label1.TabIndex = 29;
            this.label1.Text = "Statistik\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(164, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // btnPenyewa
            // 
            this.btnPenyewa.BackColor = System.Drawing.Color.Transparent;
            this.btnPenyewa.FlatAppearance.BorderSize = 0;
            this.btnPenyewa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenyewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenyewa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPenyewa.Image = ((System.Drawing.Image)(resources.GetObject("btnPenyewa.Image")));
            this.btnPenyewa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenyewa.Location = new System.Drawing.Point(73, 249);
            this.btnPenyewa.Margin = new System.Windows.Forms.Padding(0);
            this.btnPenyewa.Name = "btnPenyewa";
            this.btnPenyewa.Padding = new System.Windows.Forms.Padding(90, 0, 10, 27);
            this.btnPenyewa.Size = new System.Drawing.Size(520, 105);
            this.btnPenyewa.TabIndex = 35;
            this.btnPenyewa.Text = "                            Info Penyewaan\r\n";
            this.btnPenyewa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPenyewa.UseVisualStyleBackColor = false;
            this.btnPenyewa.Click += new System.EventHandler(this.btnPenyewa_Click);
            // 
            // btnMobil
            // 
            this.btnMobil.BackColor = System.Drawing.Color.Transparent;
            this.btnMobil.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMobil.FlatAppearance.BorderSize = 0;
            this.btnMobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMobil.Image = ((System.Drawing.Image)(resources.GetObject("btnMobil.Image")));
            this.btnMobil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMobil.Location = new System.Drawing.Point(622, 237);
            this.btnMobil.Margin = new System.Windows.Forms.Padding(0);
            this.btnMobil.Name = "btnMobil";
            this.btnMobil.Padding = new System.Windows.Forms.Padding(90, 0, 10, 27);
            this.btnMobil.Size = new System.Drawing.Size(520, 105);
            this.btnMobil.TabIndex = 36;
            this.btnMobil.Text = "                            Info Mobil\r\n";
            this.btnMobil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMobil.UseVisualStyleBackColor = false;
            this.btnMobil.Click += new System.EventHandler(this.btnMobil_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.Transparent;
            this.btnKategori.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKategori.FlatAppearance.BorderSize = 0;
            this.btnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategori.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKategori.Image = ((System.Drawing.Image)(resources.GetObject("btnKategori.Image")));
            this.btnKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategori.Location = new System.Drawing.Point(118, 433);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(0);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.btnKategori.Size = new System.Drawing.Size(520, 105);
            this.btnKategori.TabIndex = 37;
            this.btnKategori.Text = " Info Kategori Mobil\r\n\r\n";
            this.btnKategori.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKategori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnPetugas
            // 
            this.btnPetugas.BackColor = System.Drawing.Color.Transparent;
            this.btnPetugas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPetugas.FlatAppearance.BorderSize = 0;
            this.btnPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPetugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetugas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPetugas.Image = ((System.Drawing.Image)(resources.GetObject("btnPetugas.Image")));
            this.btnPetugas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPetugas.Location = new System.Drawing.Point(606, 433);
            this.btnPetugas.Margin = new System.Windows.Forms.Padding(0);
            this.btnPetugas.Name = "btnPetugas";
            this.btnPetugas.Padding = new System.Windows.Forms.Padding(90, 0, 10, 27);
            this.btnPetugas.Size = new System.Drawing.Size(520, 105);
            this.btnPetugas.TabIndex = 38;
            this.btnPetugas.Text = "                        Info Petugas\r\n";
            this.btnPetugas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPetugas.UseVisualStyleBackColor = false;
            this.btnPetugas.Click += new System.EventHandler(this.btnPetugas_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.sidebar.Controls.Add(this.menuButton);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btnPenyewaan);
            this.sidebar.Controls.Add(this.btnPembayaran);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Controls.Add(this.btnExit);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(285, 631);
            this.sidebar.MinimumSize = new System.Drawing.Size(115, 631);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(115, 631);
            this.sidebar.TabIndex = 39;
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
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
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
            // btnPenyewaan
            // 
            this.btnPenyewaan.FlatAppearance.BorderSize = 0;
            this.btnPenyewaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenyewaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenyewaan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPenyewaan.Image = ((System.Drawing.Image)(resources.GetObject("btnPenyewaan.Image")));
            this.btnPenyewaan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenyewaan.Location = new System.Drawing.Point(3, 237);
            this.btnPenyewaan.Name = "btnPenyewaan";
            this.btnPenyewaan.Size = new System.Drawing.Size(279, 83);
            this.btnPenyewaan.TabIndex = 6;
            this.btnPenyewaan.Text = "                  Penyewaan\r\n";
            this.btnPenyewaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenyewaan.UseVisualStyleBackColor = true;
            this.btnPenyewaan.Click += new System.EventHandler(this.btnPenyewaan_Click);
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
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 415);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(279, 83);
            this.button4.TabIndex = 8;
            this.button4.Text = "                Statistik\r\n";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(3, 504);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(279, 83);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "                Keluar\r\n";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // FormStatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1251, 631);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.btnPetugas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnMobil);
            this.Controls.Add(this.btnPenyewa);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormStatistik";
            this.Text = "FormStatistik";
            this.Load += new System.EventHandler(this.FormStatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPenyewa;
        private System.Windows.Forms.Button btnMobil;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnPetugas;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBeranda;
        private System.Windows.Forms.Button btnPembayaran;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPenyewaan;
    }
}