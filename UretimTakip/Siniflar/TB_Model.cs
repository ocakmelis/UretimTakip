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
    class TB_Model
    {
        /*
        ModelID
        SiparisTarihi
        KullaniciID
        GetirenKisi
        Aciklama
        BarkodID
        ModelTipiID
        ModelTurID
         */

        SqlBaglanti SqlBaglanti = new SqlBaglanti();
        public int ModelID { get; set; }
        public int SiparisTarihi { get; set; }
        public int KullaniciID { get; set; }
        public string GetirenKisi { get; set; }
        public string Aciklama { get; set; }
        public int BarkodID { get; set; }
        public int ModelTipiID { get; set; }
        public int ModelTurID { get; set; }

        public DataTable ModelListele()
        {    
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM TB_Model", SqlBaglanti.SqlBaglantiMetot());
                DataTable dt = new DataTable();

            
                adp.Fill(dt);
                return dt;
        }
        public bool ModelEkle(DateTime SiparisTarihi, string GetirenKisi, string Aciklama, int ModelTipiID, int ModelTurID)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                // MessageBox.Show(F_SiparisTarih.Value + "");

                SqlCommand ModelEkleme = new SqlCommand("INSERT INTO TB_Model(SiparisTarihi, GetirenKisi, Aciklama, ModelTipID, ModelTurID) VALUES(@p1,@p2,@p3,@p4,@p5)", SqlBaglanti.SqlBaglantiMetot());
                ModelEkleme.Parameters.AddWithValue("@p1", SiparisTarihi);
                ModelEkleme.Parameters.AddWithValue("@p2", GetirenKisi);
                ModelEkleme.Parameters.AddWithValue("@p3", Aciklama);
                ModelEkleme.Parameters.AddWithValue("@p4", ModelTipiID);
                ModelEkleme.Parameters.AddWithValue("@p5", ModelTurID);
                ModelEkleme.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                    return false;
            }
        }

        public bool ModelSil(int ModelID)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                SqlCommand ModelSilme = new SqlCommand("DELETE FROM TB_Kullanici WHERE ModelID=@P1", SqlBaglanti.SqlBaglantiMetot());
                ModelSilme.Parameters.AddWithValue("@P1", ModelID);
                ModelSilme.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }

        public bool ModelGuncelle(string Adi, string Soyadi, string Adresi, int KullaniciID)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                SqlCommand ModelGuncel = new SqlCommand("UPDATE TB_Model SET Adi = @P1, Soyadi=@P2 , Adresi=@P3, Sifre=@p4 WHERE ModelID=@P5 ", SqlBaglanti.SqlBaglantiMetot());
                ModelGuncel.Parameters.AddWithValue("@p1", Adi);
                ModelGuncel.Parameters.AddWithValue("@p2", Soyadi);
                ModelGuncel.Parameters.AddWithValue("@p3", Adresi);
                ModelGuncel.Parameters.AddWithValue("@p5", ModelID);
                ModelGuncel.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }   
        }
     //   public bool ResimYukle()
     //   {

     //   }
    }
}
