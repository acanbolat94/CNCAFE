using CnCafe.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CnCafe.UI
{
    public partial class SiparisEkle : Form
    {

        internal static Button gelenMasa;
        public SiparisEkle(Button Masa)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            gelenMasa = Masa;
        }
        #region Button methods
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (lviewSiparis.Items.Count <= 1)
            {
                MessageBox.Show("Sipariş eklenmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gelenMasa.Tag = Urunler;
                gelenMasa.BackColor = Color.Red;
                Close();
            }
        }
        private void btnYiyecekEkle_Click(object sender, EventArgs e)
        {
            YiyecekEkle();
        }

        private void YiyecekEkle()
        {
            try
            {
                Guid id = Guid.NewGuid();
                Urunler urun = (Urunler)cboxYiyecekler.SelectedItem;
                urun.Toplam = urun.Adet * urun.Fiyat;
                if (Urunler.Contains(cboxYiyecekler.SelectedItem) == true)
                {
                    urun.Adet += adet;
                    urun.Toplam = urun.Adet * urun.Fiyat;
                    SiparisListesineGoreOku();
                }
                else
                {
                    urun.ID = id;
                    urun.Adet = adet;
                    Urunler.Add(urun);
                    SiparisListesineGoreOku();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIcecekEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Guid id = Guid.NewGuid();
                Urunler urun = (Urunler)cboxIcecekler.SelectedItem;
                urun.Toplam = urun.Adet * urun.Fiyat;

                if (Urunler.Contains(cboxIcecekler.SelectedItem))
                {
                    urun.Adet += adet;
                    urun.Toplam = urun.Adet * urun.Fiyat;
                    SiparisListesineGoreOku();
                }
                else
                {
                    urun.ID = id;
                    urun.Adet = adet;
                    Urunler.Add(urun);
                    SiparisListesineGoreOku();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            Urunler.Clear();
            OdemeAl frOdemeAl = new OdemeAl();
            frOdemeAl.ShowDialog();
            this.Hide();

            XmlTextWriter xWriter = new XmlTextWriter("rapor.xml", Encoding.UTF8);

            xWriter.Formatting = Formatting.Indented;
            xWriter.WriteStartDocument();
            xWriter.WriteStartElement("Raporlar");
            xWriter.WriteStartElement("Masalar");

                xWriter.WriteStartElement("Masa");
                xWriter.WriteString(gelenMasa.Text);
                xWriter.WriteEndElement();

                xWriter.WriteStartElement("Tarih");
                xWriter.WriteString(DateTime.Now.ToString());
                xWriter.WriteEndElement();

                xWriter.WriteStartElement("Toplam tutar");
                xWriter.WriteString(genelToplam.ToString());
                xWriter.WriteEndElement();

            xWriter.WriteEndElement();
            xWriter.WriteEndElement();
            xWriter.Close();
        }
        #endregion
        #region Methods
        void ListItemOlustur(string id, string urunAdi, string fiyat, string adet, string toplam)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = id;
            lvi.SubItems.Add(urunAdi).ToString();
            lvi.SubItems.Add(fiyat.ToString());
            lvi.SubItems.Add(adet.ToString());
            lvi.SubItems.Add(toplam.ToString());
            lviewSiparis.Items.Add(lvi);
        }
        void SiparisListesineGoreOku()
        {
            lviewSiparis.Items.Clear();
            genelToplam = 0;
            foreach (Urunler urun in Urunler)
            {
                ListItemOlustur(urun.ID.ToString(), urun.Urun.ToString(), urun.Fiyat.ToString(), urun.Adet.ToString(), urun.Toplam.ToString());

                genelToplam += urun.Toplam;
            }
            ListItemOlustur("", "", "", "", "Genel Toplam : " + genelToplam);
        }
        #endregion
        #region Variables
        internal  List<Urunler> Urunler = new List<Urunler>();
        internal static double genelToplam = 0;
        int adet = 1;
        #endregion
        #region Form methods
        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            AcceptButton = btnOnayla;
            CancelButton = btnVazgec;
            lviewSiparis.FullRowSelect = true;
            #region Urunler
            Urunler Pizza = new Urunler()
            {
                Urun = "Pizza",
                Fiyat = 20,
                Adet = 1,
                YiyecekMi = true
            };

            Urunler Hamburger = new Urunler()
            {
                Urun = "Hamburger",
                Fiyat = 30,
                Adet = 1,
                YiyecekMi = true
            };

            Urunler Makarna = new Urunler()
            {
                Urun = "Makarna",
                Fiyat = 15,
                Adet = 1,
                YiyecekMi = true
            };

            Urunler.Add(Pizza);
            Urunler.Add(Hamburger);
            Urunler.Add(Makarna);

            Urunler Kola = new Urunler()
            {
                Urun = "Kola",
                Fiyat = 5,
                Adet = 1,
                YiyecekMi = false
            };

            Urunler Soda = new Urunler()
            {
                Urun = "Soda",
                Fiyat = 2.5,
                Adet = 1,
                YiyecekMi = false
            };

            Urunler Su = new Urunler()
            {
                Urun = "Su",
                Fiyat = 1.5,
                Adet = 1,
                YiyecekMi = false
            };

            Urunler.Add(Kola);
            Urunler.Add(Soda);
            Urunler.Add(Su);
            #endregion
            foreach (Urunler item in Urunler)
            {
                if (item.YiyecekMi == true)
                {
                    cboxYiyecekler.Items.Add(item);
                }
                else
                {
                    cboxIcecekler.Items.Add(item);
                }
            }
            Urunler = gelenMasa.Tag != null ? gelenMasa.Tag as List<Urunler> : new List<Urunler>();
            SiparisListesineGoreOku();
            if (Urunler.Count < 1)
            {
                btnOdemeAl.Enabled = false;
            }
        }
        #endregion
    }
}
