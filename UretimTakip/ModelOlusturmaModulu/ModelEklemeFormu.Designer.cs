
namespace UretimTakip.ModelOlusturmaModulu
{
    partial class ModelEklemeFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.F_GetirenKisi = new System.Windows.Forms.TextBox();
            this.F_Aciklama = new System.Windows.Forms.TextBox();
            this.F_SiparisTarih = new System.Windows.Forms.DateTimePicker();
            this.F_comboModelTipID = new System.Windows.Forms.ComboBox();
            this.F_comboModelTurID = new System.Windows.Forms.ComboBox();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Model Tipi ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Model Tür ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Getiren Kişi";
            // 
            // F_GetirenKisi
            // 
            this.F_GetirenKisi.Location = new System.Drawing.Point(97, 71);
            this.F_GetirenKisi.Name = "F_GetirenKisi";
            this.F_GetirenKisi.Size = new System.Drawing.Size(200, 20);
            this.F_GetirenKisi.TabIndex = 1;
            // 
            // F_Aciklama
            // 
            this.F_Aciklama.Location = new System.Drawing.Point(97, 175);
            this.F_Aciklama.Multiline = true;
            this.F_Aciklama.Name = "F_Aciklama";
            this.F_Aciklama.Size = new System.Drawing.Size(200, 80);
            this.F_Aciklama.TabIndex = 1;
            // 
            // F_SiparisTarih
            // 
            this.F_SiparisTarih.Location = new System.Drawing.Point(97, 37);
            this.F_SiparisTarih.Name = "F_SiparisTarih";
            this.F_SiparisTarih.Size = new System.Drawing.Size(200, 20);
            this.F_SiparisTarih.TabIndex = 2;
            // 
            // F_comboModelTipID
            // 
            this.F_comboModelTipID.FormattingEnabled = true;
            this.F_comboModelTipID.Location = new System.Drawing.Point(97, 104);
            this.F_comboModelTipID.Name = "F_comboModelTipID";
            this.F_comboModelTipID.Size = new System.Drawing.Size(197, 21);
            this.F_comboModelTipID.TabIndex = 3;
            // 
            // F_comboModelTurID
            // 
            this.F_comboModelTurID.FormattingEnabled = true;
            this.F_comboModelTurID.Location = new System.Drawing.Point(97, 139);
            this.F_comboModelTurID.Name = "F_comboModelTurID";
            this.F_comboModelTurID.Size = new System.Drawing.Size(197, 21);
            this.F_comboModelTurID.TabIndex = 3;
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Location = new System.Drawing.Point(16, 268);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.Btn_Kaydet.TabIndex = 6;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Btn_Guncelle);
            this.groupBox1.Controls.Add(this.Btn_Sil);
            this.groupBox1.Controls.Add(this.Btn_Kaydet);
            this.groupBox1.Controls.Add(this.F_comboModelTurID);
            this.groupBox1.Controls.Add(this.F_comboModelTipID);
            this.groupBox1.Controls.Add(this.F_SiparisTarih);
            this.groupBox1.Controls.Add(this.F_Aciklama);
            this.groupBox1.Controls.Add(this.F_GetirenKisi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model Ekleme İşlemleri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(263, 114);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(178, 268);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guncelle.TabIndex = 8;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(97, 268);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sil.TabIndex = 7;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Fotoğraf Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(406, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ModelEklemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 398);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModelEklemeFormu";
            this.Text = "ModelEklemeFormu";
            this.Load += new System.EventHandler(this.ModelEklemeFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox F_GetirenKisi;
        private System.Windows.Forms.TextBox F_Aciklama;
        private System.Windows.Forms.DateTimePicker F_SiparisTarih;
        private System.Windows.Forms.ComboBox F_comboModelTipID;
        private System.Windows.Forms.ComboBox F_comboModelTurID;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}