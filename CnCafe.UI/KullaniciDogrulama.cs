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
    public partial class KullaniciDogrulama : Form
    {
        public KullaniciDogrulama()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        #region Variables
        string kAdi = "admin";
        string kSifre = "00000";
        #endregion
        #region Form methods
        private void KullaniciDogrulama_Load(object sender, EventArgs e)
        {
            AcceptButton = btnGirisYap;
        }
        #endregion
        #region Label methods
        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void lblKapat_Click(object sender, EventArgs e)
        {
            DialogResult drKapat = MessageBox.Show("Program kapatılsın mı ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drKapat == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
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
        #endregion
        #region Button methods
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (tboxKAdi.Text == kAdi && tboxKSifre.Text == kSifre)
            {
                AnaMenu frAnamenu = new AnaMenu();
                this.Hide();
                frAnamenu.Show();
            }
            else
            {
                MessageBox.Show("Kimlik bilgileri doğrulanamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion
    }
}
