using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace UretimTakip.Siniflar
{
    class TB_Kullanici
    {
        /*KullaniciID
         * Adi
         * Soyadi
         * Sifre
         * Adresi 
         */
        SqlBaglanti SqlBaglanti = new SqlBaglanti();
       
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sifre  { get; set; }
        public string Adresi { get; set; }

        public string setKullaniciId(int kulllaniciID)
        {
            if (kulllaniciID<0)
            {
                return "Kullanıcı id 0 dan küçük olamaz!";
            }
            
            return "Başarıyla eklediniz.";
        }

        public bool GirisYap(string Adi, string Sifre)
        {
            SqlCommand GirisKontrol = new SqlCommand("SELECT * FROM TB_Kullanici WHERE Adi=@p1 AND Sifre=@p2", SqlBaglanti.SqlBaglantiMetot());
            GirisKontrol.Parameters.AddWithValue("@p1", Adi);
            GirisKontrol.Parameters.AddWithValue("@p2", Sifre);
            SqlDataReader dataReader = GirisKontrol.ExecuteReader();
            dataReader.Read();
            if (dataReader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable KullaniciListele()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM TB_Kullanici", SqlBaglanti.SqlBaglantiMetot());
                DataTable dt = new DataTable();
                adp.Fill(dt);
                baglanti.Close();
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool KullaniciEkle(string Adi, string Soyadi, string Adresi, string Sifre)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                SqlCommand KullaniciEkleme = new SqlCommand("INSERT INTO TB_Kullanici(Adi,Soyadi,Adresi,Sifre) VALUES(@p1,@p2,@p3,@p4)", SqlBaglanti.SqlBaglantiMetot());
                KullaniciEkleme.Parameters.AddWithValue("@p1", Adi);
                KullaniciEkleme.Parameters.AddWithValue("@p2", Soyadi);
                KullaniciEkleme.Parameters.AddWithValue("@p3", Adresi);
                KullaniciEkleme.Parameters.AddWithValue("@p4", Sifre);
                KullaniciEkleme.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }

        public void KullaniciSil(int KullaniciID)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                SqlCommand KullaniciSilme = new SqlCommand("DELETE FROM TB_Kullanici WHERE KullaniciID=@P1", baglanti);
                KullaniciSilme.Parameters.AddWithValue("@P1", KullaniciID);
                KullaniciSilme.ExecuteNonQuery();
                baglanti.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public bool KullaniciGuncelle(string Adi, string Soyadi, string Adresi, string Sifre, int KullaniciID)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                SqlCommand KullaniciGuncel = new SqlCommand("UPDATE TB_Kullanici SET Adi=@p1, Soyadi=@p2, Adresi=@p3, Sifre = @P4 WHERE KullaniciID=@P5 ", baglanti);
                KullaniciGuncel.Parameters.AddWithValue("@p1", Adi);
                KullaniciGuncel.Parameters.AddWithValue("@p2", Soyadi);
                KullaniciGuncel.Parameters.AddWithValue("@p3", Adresi);
                KullaniciGuncel.Parameters.AddWithValue("@p4", Sifre);
                KullaniciGuncel.Parameters.AddWithValue("@p5", Convert.ToInt32(KullaniciID));
                KullaniciGuncel.ExecuteNonQuery();
                baglanti.Close(); return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
