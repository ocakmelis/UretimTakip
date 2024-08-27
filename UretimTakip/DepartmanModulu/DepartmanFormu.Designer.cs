
namespace UretimTakip.DepartmanModulu
{
    partial class DepartmanFormu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.F_DepartmanID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.F_DepartmanAdi = new System.Windows.Forms.TextBox();
            this.BtnDepartmanGuncelle = new System.Windows.Forms.Button();
            this.BtnDepartmanSil = new System.Windows.Forms.Button();
            this.BtnDepartmanEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 228);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "DEPARTMAN ID";
            // 
            // F_DepartmanID
            // 
            this.F_DepartmanID.Location = new System.Drawing.Point(237, 92);
            this.F_DepartmanID.Name = "F_DepartmanID";
            this.F_DepartmanID.Size = new System.Drawing.Size(130, 20);
            this.F_DepartmanID.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "DEPARTMAN ADI";
            // 
            // F_DepartmanAdi
            // 
            this.F_DepartmanAdi.Location = new System.Drawing.Point(237, 55);
            this.F_DepartmanAdi.Name = "F_DepartmanAdi";
            this.F_DepartmanAdi.Size = new System.Drawing.Size(130, 20);
            this.F_DepartmanAdi.TabIndex = 21;
            // 
            // BtnDepartmanGuncelle
            // 
            this.BtnDepartmanGuncelle.Location = new System.Drawing.Point(458, 126);
            this.BtnDepartmanGuncelle.Name = "BtnDepartmanGuncelle";
            this.BtnDepartmanGuncelle.Size = new System.Drawing.Size(75, 23);
            this.BtnDepartmanGuncelle.TabIndex = 23;
            this.BtnDepartmanGuncelle.Text = "GÜNCELLE";
            this.BtnDepartmanGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnDepartmanSil
            // 
            this.BtnDepartmanSil.Location = new System.Drawing.Point(458, 85);
            this.BtnDepartmanSil.Name = "BtnDepartmanSil";
            this.BtnDepartmanSil.Size = new System.Drawing.Size(75, 23);
            this.BtnDepartmanSil.TabIndex = 24;
            this.BtnDepartmanSil.Text = "SİL";
            this.BtnDepartmanSil.UseVisualStyleBackColor = true;
            this.BtnDepartmanSil.Click += new System.EventHandler(this.BtnDepartmanSil_Click);
            // 
            // BtnDepartmanEkle
            // 
            this.BtnDepartmanEkle.Location = new System.Drawing.Point(458, 51);
            this.BtnDepartmanEkle.Name = "BtnDepartmanEkle";
            this.BtnDepartmanEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnDepartmanEkle.TabIndex = 25;
            this.BtnDepartmanEkle.Text = "EKLE";
            this.BtnDepartmanEkle.UseVisualStyleBackColor = true;
            this.BtnDepartmanEkle.Click += new System.EventHandler(this.BtnDepartmanEkle_Click);
            // 
            // DepartmanFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDepartmanGuncelle);
            this.Controls.Add(this.BtnDepartmanSil);
            this.Controls.Add(this.BtnDepartmanEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F_DepartmanAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_DepartmanID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartmanFormu";
            this.Text = "DepartmanFormu";
            this.Load += new System.EventHandler(this.DepartmanFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_DepartmanID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox F_DepartmanAdi;
        private System.Windows.Forms.Button BtnDepartmanGuncelle;
        private System.Windows.Forms.Button BtnDepartmanSil;
        private System.Windows.Forms.Button BtnDepartmanEkle;
    }
}