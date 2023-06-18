namespace CnCafe.UI
{
    partial class SiparisEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.cboxYiyecekler = new System.Windows.Forms.ComboBox();
            this.cboxIcecekler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lviewSiparis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.btnYiyecekEkle = new System.Windows.Forms.Button();
            this.btnIcecekEkle = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yiyecekler";
            // 
            // cboxYiyecekler
            // 
            this.cboxYiyecekler.FormattingEnabled = true;
            this.cboxYiyecekler.Location = new System.Drawing.Point(92, 5);
            this.cboxYiyecekler.Name = "cboxYiyecekler";
            this.cboxYiyecekler.Size = new System.Drawing.Size(302, 24);
            this.cboxYiyecekler.TabIndex = 1;
            // 
            // cboxIcecekler
            // 
            this.cboxIcecekler.FormattingEnabled = true;
            this.cboxIcecekler.Location = new System.Drawing.Point(92, 35);
            this.cboxIcecekler.Name = "cboxIcecekler";
            this.cboxIcecekler.Size = new System.Drawing.Size(302, 24);
            this.cboxIcecekler.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "İçecekler";
            // 
            // lviewSiparis
            // 
            this.lviewSiparis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lviewSiparis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lviewSiparis.Location = new System.Drawing.Point(92, 65);
            this.lviewSiparis.Name = "lviewSiparis";
            this.lviewSiparis.Size = new System.Drawing.Size(502, 152);
            this.lviewSiparis.TabIndex = 3;
            this.lviewSiparis.UseCompatibleStateImageBehavior = false;
            this.lviewSiparis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adet";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Toplam";
            this.columnHeader5.Width = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürünler";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVazgec.Location = new System.Drawing.Point(92, 223);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(502, 30);
            this.btnVazgec.TabIndex = 4;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(6, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(591, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Sipariş al";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(6, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(591, 1);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnayla.Location = new System.Drawing.Point(92, 259);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(502, 30);
            this.btnOnayla.TabIndex = 5;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdemeAl.Location = new System.Drawing.Point(92, 295);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(502, 30);
            this.btnOdemeAl.TabIndex = 6;
            this.btnOdemeAl.Text = "Ödeme al";
            this.btnOdemeAl.UseVisualStyleBackColor = true;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // btnYiyecekEkle
            // 
            this.btnYiyecekEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYiyecekEkle.Location = new System.Drawing.Point(400, 5);
            this.btnYiyecekEkle.Name = "btnYiyecekEkle";
            this.btnYiyecekEkle.Size = new System.Drawing.Size(194, 24);
            this.btnYiyecekEkle.TabIndex = 9;
            this.btnYiyecekEkle.Text = "Ekle";
            this.btnYiyecekEkle.UseVisualStyleBackColor = true;
            this.btnYiyecekEkle.Click += new System.EventHandler(this.btnYiyecekEkle_Click);
            // 
            // btnIcecekEkle
            // 
            this.btnIcecekEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcecekEkle.Location = new System.Drawing.Point(400, 35);
            this.btnIcecekEkle.Name = "btnIcecekEkle";
            this.btnIcecekEkle.Size = new System.Drawing.Size(194, 24);
            this.btnIcecekEkle.TabIndex = 10;
            this.btnIcecekEkle.Text = "Ekle";
            this.btnIcecekEkle.UseVisualStyleBackColor = true;
            this.btnIcecekEkle.Click += new System.EventHandler(this.btnIcecekEkle_Click);
            // 
            // SiparisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 402);
            this.Controls.Add(this.btnIcecekEkle);
            this.Controls.Add(this.btnYiyecekEkle);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lviewSiparis);
            this.Controls.Add(this.cboxIcecekler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxYiyecekler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiparisEkle";
            this.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Text = "SiparisEkle";
            this.Load += new System.EventHandler(this.SiparisEkle_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxYiyecekler;
        private System.Windows.Forms.ComboBox cboxIcecekler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lviewSiparis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Button btnYiyecekEkle;
        private System.Windows.Forms.Button btnIcecekEkle;
    }
}