namespace SistemSewaMobil.View
{
    partial class FormBeranda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeranda));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnPenyewaan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.jam = new System.Windows.Forms.Timer(this.components);
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.lbljam = new System.Windows.Forms.Label();
            this.btnPenyewa = new System.Windows.Forms.Button();
            this.btnMobil = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnPetugas = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.sidebar.Controls.Add(this.menuButton);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btnPenyewaan);
            this.sidebar.Controls.Add(this.button3);
            this.sidebar.Controls.Add(this.btnExit);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(285, 1020);
            this.sidebar.MinimumSize = new System.Drawing.Size(115, 631);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(120, 901);
            this.sidebar.TabIndex = 29;
            this.sidebar.WrapContents = false;
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
            this.menuButton.Size = new System.Drawing.Size(279, 200);
            this.menuButton.TabIndex = 0;
            this.menuButton.Text = "                Menu\n";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(3, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 118);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, -31);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(279, 188);
            this.button6.TabIndex = 10;
            this.button6.Text = "                Beranda";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnPenyewaan
            // 
            this.btnPenyewaan.FlatAppearance.BorderSize = 0;
            this.btnPenyewaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenyewaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenyewaan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPenyewaan.Image = ((System.Drawing.Image)(resources.GetObject("btnPenyewaan.Image")));
            this.btnPenyewaan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenyewaan.Location = new System.Drawing.Point(3, 333);
            this.btnPenyewaan.Name = "btnPenyewaan";
            this.btnPenyewaan.Size = new System.Drawing.Size(279, 157);
            this.btnPenyewaan.TabIndex = 6;
            this.btnPenyewaan.Text = "                  Penyewaan\r\n";
            this.btnPenyewaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPenyewaan.UseVisualStyleBackColor = true;
            this.btnPenyewaan.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 496);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(279, 157);
            this.button3.TabIndex = 7;
            this.button3.Text = "                Pembayaran\r\n";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(3, 659);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(279, 161);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "                Keluar\r\n";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(689, -27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(751, 419);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // jam
            // 
            this.jam.Interval = 1000;
            this.jam.Tick += new System.EventHandler(this.jam_Tick);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick_1);
            // 
            // lbljam
            // 
            this.lbljam.AutoSize = true;
            this.lbljam.BackColor = System.Drawing.Color.Transparent;
            this.lbljam.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbljam.Location = new System.Drawing.Point(1724, 19);
            this.lbljam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbljam.Name = "lbljam";
            this.lbljam.Size = new System.Drawing.Size(131, 39);
            this.lbljam.TabIndex = 30;
            this.lbljam.Text = "00:00:00";
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
            this.btnPenyewa.Location = new System.Drawing.Point(397, 394);
            this.btnPenyewa.Margin = new System.Windows.Forms.Padding(0);
            this.btnPenyewa.Name = "btnPenyewa";
            this.btnPenyewa.Padding = new System.Windows.Forms.Padding(90, 0, 10, 27);
            this.btnPenyewa.Size = new System.Drawing.Size(520, 105);
            this.btnPenyewa.TabIndex = 36;
            this.btnPenyewa.Text = "                            Info Penyewa\r\n";
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
            this.btnMobil.Location = new System.Drawing.Point(1170, 394);
            this.btnMobil.Margin = new System.Windows.Forms.Padding(0);
            this.btnMobil.Name = "btnMobil";
            this.btnMobil.Padding = new System.Windows.Forms.Padding(90, 0, 10, 27);
            this.btnMobil.Size = new System.Drawing.Size(520, 105);
            this.btnMobil.TabIndex = 37;
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
            this.btnKategori.Location = new System.Drawing.Point(450, 534);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(0);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.btnKategori.Size = new System.Drawing.Size(520, 105);
            this.btnKategori.TabIndex = 38;
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
            this.btnPetugas.Location = new System.Drawing.Point(1170, 534);
            this.btnPetugas.Margin = new System.Windows.Forms.Padding(0);
            this.btnPetugas.Name = "btnPetugas";
            this.btnPetugas.Padding = new System.Windows.Forms.Padding(90, 0, 10, 27);
            this.btnPetugas.Size = new System.Drawing.Size(520, 105);
            this.btnPetugas.TabIndex = 39;
            this.btnPetugas.Text = "                        Info Petugas\r\n";
            this.btnPetugas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPetugas.UseVisualStyleBackColor = false;
            this.btnPetugas.Click += new System.EventHandler(this.btnPetugas_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.Transparent;
            this.btnRiwayat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRiwayat.FlatAppearance.BorderSize = 0;
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiwayat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRiwayat.Image = ((System.Drawing.Image)(resources.GetObject("btnRiwayat.Image")));
            this.btnRiwayat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRiwayat.Location = new System.Drawing.Point(823, 682);
            this.btnRiwayat.Margin = new System.Windows.Forms.Padding(0);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.Padding = new System.Windows.Forms.Padding(40, 0, 10, 0);
            this.btnRiwayat.Size = new System.Drawing.Size(520, 105);
            this.btnRiwayat.TabIndex = 41;
            this.btnRiwayat.Text = " Info Riwayat \r\n\r\n";
            this.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRiwayat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(987, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 42;
            this.label1.Text = "Welcome!!";
            // 
            // FormBeranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1880, 901);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.btnPenyewa);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnPetugas);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnMobil);
            this.Controls.Add(this.lbljam);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormBeranda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBeranda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBeranda_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnPenyewaan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer jam;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Label lbljam;
        private System.Windows.Forms.Button btnPenyewa;
        private System.Windows.Forms.Button btnMobil;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnPetugas;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Label label1;
    }
}