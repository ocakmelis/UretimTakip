using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UretimTakip.KullaniciModulu
{
    public partial class KullaniciEklemeFormu : Form
    {
        public KullaniciEklemeFormu()
        {
            InitializeComponent();
        }

        Siniflar.TB_Kullanici TB_Kullanici = new Siniflar.TB_Kullanici();

        private void KullaniciEklemeFormu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TB_Kullanici.KullaniciListele();
        }

        private void BtnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (F_KullaniciAdi.Text != "" && F_KullaniciSoyadi.Text != "" && F_KullaniciAdresi.Text != "")
            {
                if (TB_Kullanici.KullaniciEkle(F_KullaniciAdi.Text, F_KullaniciSoyadi.Text, F_KullaniciAdresi.Text, F_KullaniciSifre.Text))
                {
                    MessageBox.Show("EKLEME İŞLEMİ BAŞARILI");
                    dataGridView1.DataSource = TB_Kullanici.KullaniciListele();
                }
                else
                {
                    MessageBox.Show("HATALI GİRİŞ");
                }
            }
            else
            {
                MessageBox.Show("BOŞ BIRAKTIĞINIZ YERLERİ DOLDURUNUZ!");
            }
        }

        private void BtnKullaniciSil_Click(object sender, EventArgs e)
        {
            int KullaniciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            TB_Kullanici.KullaniciSil(KullaniciID);
            MessageBox.Show("Kullanıcı Silindi!");
            dataGridView1.DataSource = TB_Kullanici.KullaniciListele();

        }
        
        private void BtnKullaniciGuncelle_Click(object sender, EventArgs e)
        { 
            int KullaniciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (TB_Kullanici.KullaniciGuncelle(F_KullaniciAdi.Text, F_KullaniciSoyadi.Text, F_KullaniciAdresi.Text,F_KullaniciSifre.Text, Convert.ToInt32(F_KullaniciID.Text)))
            {
                MessageBox.Show("Kullanıcı Güncellendi!");
                dataGridView1.DataSource = TB_Kullanici.KullaniciListele();
            }
            else
            {
                MessageBox.Show("Güncellenmedi");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // KullaniciID=0      Adi=1      Soyadi=2     Sifre=3    Adresi=3 

            F_KullaniciID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            F_KullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            F_KullaniciSoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            F_KullaniciSifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            F_KullaniciAdresi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}

