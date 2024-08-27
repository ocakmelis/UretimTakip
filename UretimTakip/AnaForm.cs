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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            KullaniciModulu.KullaniciEklemeFormu kullaniciEklemeFormu = new KullaniciModulu.KullaniciEklemeFormu();
            kullaniciEklemeFormu.ShowDialog();

           
        }

        private void ModelEklemeFormu(object sender, EventArgs e)
        {
            ModelOlusturmaModulu.ModelEklemeFormu modelEklemeFormu = new ModelOlusturmaModulu.ModelEklemeFormu();
            modelEklemeFormu.ShowDialog();
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            DepartmanModulu.DepartmanFormu departmanFormu = new DepartmanModulu.DepartmanFormu();
            departmanFormu.ShowDialog();
        }
    }
}
