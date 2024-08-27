using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using UretimTakip.Siniflar;

namespace UretimTakip.DepartmanModulu
{
    public partial class DepartmanFormu : Form
    {
        public DepartmanFormu()
        {
            InitializeComponent();
        }
        Siniflar.TB_Departman TB_Departman = new Siniflar.TB_Departman();
        private void DepartmanFormu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TB_Departman.DepartmanListele();
        }

        private void BtnDepartmanEkle_Click(object sender, EventArgs e)
        {
            TB_Departman tB_Departman = new TB_Departman(F_DepartmanAdi.Text);
            if (F_DepartmanAdi.Text != "")
            {
                if (tB_Departman.CreateDepartman() == true)
                {
                    MessageBox.Show("EKLEME İŞLEMİ BAŞARILI");
                    dataGridView1.DataSource = TB_Departman.DepartmanListele();
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
       
        private void BtnDepartmanSil_Click(object sender, EventArgs e)
        {
            int DepartmanID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            TB_Departman.DeleteDepartman(DepartmanID);
            MessageBox.Show("Departman Silindi!");
            dataGridView1.DataSource = TB_Departman.DepartmanListele();
        }

    }
}
