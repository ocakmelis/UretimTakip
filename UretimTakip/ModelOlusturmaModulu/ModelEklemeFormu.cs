using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UretimTakip.ModelOlusturmaModulu
{
    public partial class ModelEklemeFormu : Form
    {
        String ResimYolu;
        public ModelEklemeFormu()
        {
            InitializeComponent();
        }
        Siniflar.TB_Model TB_Model = new Siniflar.TB_Model();
        private void ModelEklemeFormu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TB_Model.ModelListele();
            FillCombo();
        }

        private void FillCombo()
        {
            try
            {

                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                DataTable dt = new DataTable();
                //SqlDataAdapter dtatapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Select * from TB_ModelTipi", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                F_comboModelTipID.ValueMember = "ModelTipID";
                F_comboModelTipID.DisplayMember = "ModelTipi";
                F_comboModelTipID.DataSource = dt;
                //dtatapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboTur()
        {
            try
            {

                SqlConnection baglanti = new SqlConnection("Data Source=win7;Initial Catalog=AYAKKABI_DB;Integrated Security=True");
                baglanti.Open();
                DataTable dt = new DataTable();
                //SqlDataAdapter dtatapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Select * from TB_ModelTuru", baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                F_comboModelTipID.ValueMember = "ModelTurID";
                F_comboModelTipID.DisplayMember = "ModelTuru";
                F_comboModelTipID.DataSource = dt;
                //dtatapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            if (F_GetirenKisi.Text != "" && F_Aciklama.Text != "" && F_comboModelTipID.SelectedValue != "" && F_comboModelTurID.SelectedValue != "")
            {
                if(TB_Model.ModelEkle(Convert.ToDateTime(F_SiparisTarih.Value), F_GetirenKisi.Text, F_Aciklama.Text, Convert.ToInt32(F_comboModelTipID.SelectedValue), Convert.ToInt32(F_comboModelTurID.SelectedValue)))
                {
                    MessageBox.Show("EKLEME İŞLEMİ BAŞARILI");
                }
                else
                {
                    MessageBox.Show("EKLEME İŞLEMİ HATALI");
                }
            }
            else
            {
                MessageBox.Show("BOŞ BIRAKTIĞINIZ YERLERİ DOLDURUNUZ!");
            }
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            /*
             * * Datagrid'in kayıtlarından herhangi birisine tıklandığında o tıklanana satırın 
             * bilgilerini belirtilen textboxların içerisine veriyi gönderir.
             * ModelID
             * SiparisTarihi
             * KullaniciID
             * GetirenKisi
             * Aciklama
             * BarkodID
             * ModelTipiID
             * ModelTurID
             */
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int ModelID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            TB_Model.ModelSil(ModelID);
            MessageBox.Show("Model Silindi!");
            dataGridView1.DataSource = TB_Model.ModelListele();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            int ModelID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            if (TB_Model.ModelGuncelle(F_GetirenKisi.Text, F_Aciklama.Text,  F_comboModelTipID.SelectedValue.ToString(), Convert.ToInt32(F_comboModelTurID.SelectedValue)))
            {
                MessageBox.Show("Güncellendi!");
                dataGridView1.DataSource = TB_Model.ModelListele();
            }
            else
            {
                MessageBox.Show("Güncellenmedi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ResimSec = new OpenFileDialog();
            ResimSec.ShowDialog();
            pictureBox1.Image = Image.FromFile(ResimSec.FileName);
            ResimYolu = ResimSec.FileName;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "")
            {
                MessageBox.Show("BU ADAYIN RESMİ YOK!");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            }
        }
    }
}
