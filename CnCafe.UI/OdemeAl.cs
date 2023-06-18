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
    public partial class OdemeAl : Form
    {
        public OdemeAl()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ControlBox = false;
        }
        #region Variables
        #endregion
        #region Button methods
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (tboxNakitOdeme.Text != lblOdeme.Text)
                {
                    MessageBox.Show("Hesap ile verilen para uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ödeme alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblOdeme.Text = "";
                    SiparisEkle.gelenMasa.BackColor = Color.Green;
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış değer girildi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Form methods
        private void OdemeAl_Load(object sender, EventArgs e)
        {
            lblOdeme.Text = SiparisEkle.genelToplam.ToString();
        }
        #endregion
    }
}
