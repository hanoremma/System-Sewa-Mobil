namespace SistemSewaMobil
{
    partial class FormMobil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMobil));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSelesaiMobil = new System.Windows.Forms.Button();
            this.btnHapusMobil = new System.Windows.Forms.Button();
            this.btnTambahMobil = new System.Windows.Forms.Button();
            this.btnUpdateMobil = new System.Windows.Forms.Button();
            this.lvwDaftarMobil = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCariMobil = new System.Windows.Forms.TextBox();
            this.btnCariMobil = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informasi Mobil";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 701F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvwDaftarMobil, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 171);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 370);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel2.Controls.Add(this.btnSelesaiMobil, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHapusMobil, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTambahMobil, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdateMobil, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 328);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(634, 39);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSelesaiMobil
            // 
            this.btnSelesaiMobil.Location = new System.Drawing.Point(527, 3);
            this.btnSelesaiMobil.Name = "btnSelesaiMobil";
            this.btnSelesaiMobil.Size = new System.Drawing.Size(107, 32);
            this.btnSelesaiMobil.TabIndex = 0;
            this.btnSelesaiMobil.Text = "Selesai";
            this.btnSelesaiMobil.UseVisualStyleBackColor = true;
            this.btnSelesaiMobil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHapusMobil
            // 
            this.btnHapusMobil.Location = new System.Drawing.Point(174, 3);
            this.btnHapusMobil.Name = "btnHapusMobil";
            this.btnHapusMobil.Size = new System.Drawing.Size(74, 32);
            this.btnHapusMobil.TabIndex = 1;
            this.btnHapusMobil.Text = "Hapus";
            this.btnHapusMobil.UseVisualStyleBackColor = true;
            this.btnHapusMobil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTambahMobil
            // 
            this.btnTambahMobil.Location = new System.Drawing.Point(2, 2);
            this.btnTambahMobil.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambahMobil.Name = "btnTambahMobil";
            this.btnTambahMobil.Size = new System.Drawing.Size(82, 35);
            this.btnTambahMobil.TabIndex = 3;
            this.btnTambahMobil.Text = "Tambah";
            this.btnTambahMobil.UseVisualStyleBackColor = true;
            this.btnTambahMobil.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdateMobil
            // 
            this.btnUpdateMobil.Location = new System.Drawing.Point(90, 3);
            this.btnUpdateMobil.Name = "btnUpdateMobil";
            this.btnUpdateMobil.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateMobil.TabIndex = 2;
            this.btnUpdateMobil.Text = "Update";
            this.btnUpdateMobil.UseVisualStyleBackColor = true;
            this.btnUpdateMobil.Click += new System.EventHandler(this.button3_Click);
            // 
            // lvwDaftarMobil
            // 
            this.lvwDaftarMobil.HideSelection = false;
            this.lvwDaftarMobil.Location = new System.Drawing.Point(3, 3);
            this.lvwDaftarMobil.Name = "lvwDaftarMobil";
            this.lvwDaftarMobil.Size = new System.Drawing.Size(693, 319);
            this.lvwDaftarMobil.TabIndex = 0;
            this.lvwDaftarMobil.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cari data mobil";
            // 
            // txtCariMobil
            // 
            this.txtCariMobil.Location = new System.Drawing.Point(116, 139);
            this.txtCariMobil.Name = "txtCariMobil";
            this.txtCariMobil.Size = new System.Drawing.Size(456, 20);
            this.txtCariMobil.TabIndex = 27;
            // 
            // btnCariMobil
            // 
            this.btnCariMobil.Location = new System.Drawing.Point(584, 136);
            this.btnCariMobil.Name = "btnCariMobil";
            this.btnCariMobil.Size = new System.Drawing.Size(84, 21);
            this.btnCariMobil.TabIndex = 28;
            this.btnCariMobil.Text = "Cari";
            this.btnCariMobil.UseVisualStyleBackColor = true;
            this.btnCariMobil.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(852, 565);
            this.Controls.Add(this.btnCariMobil);
            this.Controls.Add(this.txtCariMobil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMobil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobil";
            this.Load += new System.EventHandler(this.infoMobilTersedia_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView lvwDaftarMobil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSelesaiMobil;
        private System.Windows.Forms.Button btnHapusMobil;
        private System.Windows.Forms.Button btnUpdateMobil;
        private System.Windows.Forms.Button btnTambahMobil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCariMobil;
        private System.Windows.Forms.Button btnCariMobil;
    }
}