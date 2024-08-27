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
    class TB_Departman
    {
        /*
         DepartmanID
         DepartmanAdi
         */
        SqlBaglanti SqlBaglanti = new SqlBaglanti();

        public string DepartmanAdi;

        public TB_Departman(string DepartmanAdi)
        {
            this.DepartmanAdi = DepartmanAdi;

        }
        public TB_Departman()
        {

        }
        public bool CreateDepartman()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                SqlCommand DepartmanEkleme = new SqlCommand("INSERT INTO TB_Departman(DepartmanAdi) VALUES(@p2)", baglanti);
                DepartmanEkleme.Parameters.AddWithValue("@p2", this.DepartmanAdi);
                DepartmanEkleme.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void DeleteDepartman(int DepartmanID)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                SqlCommand DepartmanSilme = new SqlCommand("DELETE FROM TB_Departman WHERE DepartmanID=@P1", baglanti);
                DepartmanSilme.Parameters.AddWithValue("@P1", DepartmanID);
                DepartmanSilme.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable DepartmanListele()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM TB_Departman", SqlBaglanti.SqlBaglantiMetot());
                DataTable dt = new DataTable();
                adp.Fill(dt);
                baglanti.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
