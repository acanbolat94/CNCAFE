using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CnCafe.UI
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }
        #region Label events
        private void lblKapat_MouseEnter(object sender, EventArgs e)
        {
            Label l = sender as Label;
            l.BackColor = Color.Red;
            l.ForeColor = Color.White;
        }

        private void lblKapat_MouseLeave(object sender, EventArgs e)
        {
            Label l = sender as Label;
            l.BackColor = Color.White;
            l.ForeColor = Color.Black;
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            DialogResult drKapat = MessageBox.Show("Program kapatılsın mı ? ", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (drKapat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Degiskenler
        int sayac = 0;
        Button b;
        #endregion
        #region Button methods
        private void Btn_Click(object sender, EventArgs e)
        {
            b = sender as Button;
            SiparisEkle frSiparisEkle = new SiparisEkle(b);
            frSiparisEkle.ShowDialog();
        }
        #endregion
        #region Form methods
        private void AnaMenu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sayac++;
                    Button btn = new Button();
                    btn.Size = new Size(100,100);
                    btn.Left = (100 + 100) * j + 450;
                    btn.Top = ((100 + 20) * i) + 80;
                    btn.Text = "Masa\n" + sayac;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += Btn_Click;
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.White;
                    if (sayac != 10 && sayac != 11)
                    {
                        gboxMasalar.Controls.Add(btn);
                    }
                }
            }
        }
        #endregion
    }
}
