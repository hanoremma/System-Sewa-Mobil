namespace SistemSewaMobil.View
{
    partial class FormDetailSewa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailSewa));
            this.btnCariDS = new System.Windows.Forms.Button();
            this.txtCariDS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTambahDS = new System.Windows.Forms.Button();
            this.btnUpdateDS = new System.Windows.Forms.Button();
            this.btnHapusDS = new System.Windows.Forms.Button();
            this.btnSelesaiDS = new System.Windows.Forms.Button();
            this.lvwDaftarDS = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCariDS
            // 
            this.btnCariDS.Location = new System.Drawing.Point(946, 118);
            this.btnCariDS.Name = "btnCariDS";
            this.btnCariDS.Size = new System.Drawing.Size(108, 33);
            this.btnCariDS.TabIndex = 33;
            this.btnCariDS.Text = "Cari";
            this.btnCariDS.UseVisualStyleBackColor = true;
            this.btnCariDS.Click += new System.EventHandler(this.btnCariDS_Click);
            // 
            // txtCariDS
            // 
            this.txtCariDS.Location = new System.Drawing.Point(191, 127);
            this.txtCariDS.Name = "txtCariDS";
            this.txtCariDS.Size = new System.Drawing.Size(749, 20);
            this.txtCariDS.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(59, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cari data Penyewa";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lvwDaftarDS, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(56, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.74374F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.25627F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 491);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 757F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnTambahDS, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdateDS, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHapusDS, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSelesaiDS, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 433);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1018, 55);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnTambahDS
            // 
            this.btnTambahDS.Location = new System.Drawing.Point(3, 3);
            this.btnTambahDS.Name = "btnTambahDS";
            this.btnTambahDS.Size = new System.Drawing.Size(72, 32);
            this.btnTambahDS.TabIndex = 2;
            this.btnTambahDS.Text = "Tambah";
            this.btnTambahDS.UseVisualStyleBackColor = true;
            this.btnTambahDS.Click += new System.EventHandler(this.btnTambahDS_Click);
            // 
            // btnUpdateDS
            // 
            this.btnUpdateDS.Location = new System.Drawing.Point(87, 3);
            this.btnUpdateDS.Name = "btnUpdateDS";
            this.btnUpdateDS.Size = new System.Drawing.Size(74, 32);
            this.btnUpdateDS.TabIndex = 1;
            this.btnUpdateDS.Text = "Update";
            this.btnUpdateDS.UseVisualStyleBackColor = true;
            this.btnUpdateDS.Click += new System.EventHandler(this.btnUpdateDS_Click);
            // 
            // btnHapusDS
            // 
            this.btnHapusDS.Location = new System.Drawing.Point(169, 3);
            this.btnHapusDS.Name = "btnHapusDS";
            this.btnHapusDS.Size = new System.Drawing.Size(80, 32);
            this.btnHapusDS.TabIndex = 0;
            this.btnHapusDS.Text = "Hapus";
            this.btnHapusDS.UseVisualStyleBackColor = true;
            this.btnHapusDS.Click += new System.EventHandler(this.btnHapusDS_Click);
            // 
            // btnSelesaiDS
            // 
            this.btnSelesaiDS.Location = new System.Drawing.Point(926, 3);
            this.btnSelesaiDS.Name = "btnSelesaiDS";
            this.btnSelesaiDS.Size = new System.Drawing.Size(89, 32);
            this.btnSelesaiDS.TabIndex = 3;
            this.btnSelesaiDS.Text = "Selesai";
            this.btnSelesaiDS.UseVisualStyleBackColor = true;
            this.btnSelesaiDS.Click += new System.EventHandler(this.btnSelesaiDS_Click);
            // 
            // lvwDaftarDS
            // 
            this.lvwDaftarDS.HideSelection = false;
            this.lvwDaftarDS.Location = new System.Drawing.Point(3, 3);
            this.lvwDaftarDS.Name = "lvwDaftarDS";
            this.lvwDaftarDS.Size = new System.Drawing.Size(1018, 424);
            this.lvwDaftarDS.TabIndex = 0;
            this.lvwDaftarDS.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Informasi Penyewa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(946, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDetailSewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1120, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCariDS);
            this.Controls.Add(this.txtCariDS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDetailSewa";
            this.Text = "FormDetailSewa";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCariDS;
        private System.Windows.Forms.TextBox txtCariDS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnTambahDS;
        private System.Windows.Forms.Button btnUpdateDS;
        private System.Windows.Forms.Button btnHapusDS;
        private System.Windows.Forms.Button btnSelesaiDS;
        private System.Windows.Forms.ListView lvwDaftarDS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}