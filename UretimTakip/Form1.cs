using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UretimTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Siniflar.TB_Kullanici TB_Kullanici = new Siniflar.TB_Kullanici();
   
        private void btnGiris_Click(object sender, EventArgs e)
        {
            

            if (TB_Kullanici.GirisYap(F_KullaniciAdi.Text, F_KullaniciSifresi.Text)) 
            {
                Siniflar.TB_Kullanici TB_Kullanici2 = new Siniflar.TB_Kullanici();

                TB_Kullanici.KullaniciId();
                int kullaniciid = TB_Kullanici.KullaniciId();
                this.Hide(); //giriş yapıp ana forma atadıktan sonra giriş yap ekranını kapatır.
                AnaForm anaForm = new AnaForm();
                anaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlış!");
            }
        }
    }
}
