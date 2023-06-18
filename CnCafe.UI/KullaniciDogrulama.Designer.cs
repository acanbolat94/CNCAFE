namespace CnCafe.UI
{
    partial class KullaniciDogrulama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciDogrulama));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKapat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxKAdi = new System.Windows.Forms.TextBox();
            this.tboxKSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(869, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel1.Text = "Kullanıcı doğrulama";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(869, 1);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Controls.Add(this.lblMinimize, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblKapat, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 53);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblMinimize
            // 
            this.lblMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinimize.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinimize.Location = new System.Drawing.Point(752, 5);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(51, 43);
            this.lblMinimize.TabIndex = 2;
            this.lblMinimize.Text = "-";
            this.lblMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.lblKapat_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblKapat_MouseLeave);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(737, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kimlik doğrulama";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKapat
            // 
            this.lblKapat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKapat.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.Location = new System.Drawing.Point(809, 5);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(51, 43);
            this.lblKapat.TabIndex = 0;
            this.lblKapat.Text = "X";
            this.lblKapat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            this.lblKapat.MouseEnter += new System.EventHandler(this.lblKapat_MouseEnter);
            this.lblKapat.MouseLeave += new System.EventHandler(this.lblKapat_MouseLeave);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(869, 1);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kullanıcı adı";
            // 
            // tboxKAdi
            // 
            this.tboxKAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tboxKAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxKAdi.Location = new System.Drawing.Point(310, 263);
            this.tboxKAdi.Name = "tboxKAdi";
            this.tboxKAdi.Size = new System.Drawing.Size(303, 28);
            this.tboxKAdi.TabIndex = 5;
            // 
            // tboxKSifre
            // 
            this.tboxKSifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tboxKSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxKSifre.Location = new System.Drawing.Point(310, 297);
            this.tboxKSifre.Name = "tboxKSifre";
            this.tboxKSifre.Size = new System.Drawing.Size(303, 28);
            this.tboxKSifre.TabIndex = 7;
            this.tboxKSifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Şifre";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGirisYap.Location = new System.Drawing.Point(310, 331);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(303, 30);
            this.btnGirisYap.TabIndex = 8;
            this.btnGirisYap.Text = "Giriş yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(746, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kullanıcı adı : admin\r\nŞifre : 00000";
            // 
            // KullaniciDogrulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.tboxKSifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxKAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciDogrulama";
            this.Text = "KullaniciDogrulama";
            this.Load += new System.EventHandler(this.KullaniciDogrulama_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxKAdi;
        private System.Windows.Forms.TextBox tboxKSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label3;
    }
}