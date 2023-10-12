namespace GELISTIRME
{
    partial class FormSinifListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSinifListesi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPasif = new System.Windows.Forms.RadioButton();
            this.radioButtonAktif = new System.Windows.Forms.RadioButton();
            this.comboBoxBolumu = new System.Windows.Forms.ComboBox();
            this.comboBoxSinifOgretmeni = new System.Windows.Forms.ComboBox();
            this.textBoxSinifSubesi = new System.Windows.Forms.TextBox();
            this.textBoxSinifNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSiniflar = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTemizle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiniflar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPasif);
            this.groupBox1.Controls.Add(this.radioButtonAktif);
            this.groupBox1.Controls.Add(this.comboBoxBolumu);
            this.groupBox1.Controls.Add(this.comboBoxSinifOgretmeni);
            this.groupBox1.Controls.Add(this.textBoxSinifSubesi);
            this.groupBox1.Controls.Add(this.textBoxSinifNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SINIF BİLGİLERİ";
            // 
            // radioButtonPasif
            // 
            this.radioButtonPasif.AutoSize = true;
            this.radioButtonPasif.Location = new System.Drawing.Point(659, 69);
            this.radioButtonPasif.Name = "radioButtonPasif";
            this.radioButtonPasif.Size = new System.Drawing.Size(62, 24);
            this.radioButtonPasif.TabIndex = 10;
            this.radioButtonPasif.TabStop = true;
            this.radioButtonPasif.Text = "Pasif";
            this.radioButtonPasif.UseVisualStyleBackColor = true;
            // 
            // radioButtonAktif
            // 
            this.radioButtonAktif.AutoSize = true;
            this.radioButtonAktif.Location = new System.Drawing.Point(566, 69);
            this.radioButtonAktif.Name = "radioButtonAktif";
            this.radioButtonAktif.Size = new System.Drawing.Size(59, 24);
            this.radioButtonAktif.TabIndex = 9;
            this.radioButtonAktif.TabStop = true;
            this.radioButtonAktif.Text = "Aktif";
            this.radioButtonAktif.UseVisualStyleBackColor = true;
            // 
            // comboBoxBolumu
            // 
            this.comboBoxBolumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBolumu.FormattingEnabled = true;
            this.comboBoxBolumu.Location = new System.Drawing.Point(543, 18);
            this.comboBoxBolumu.Name = "comboBoxBolumu";
            this.comboBoxBolumu.Size = new System.Drawing.Size(198, 28);
            this.comboBoxBolumu.TabIndex = 8;
            // 
            // comboBoxSinifOgretmeni
            // 
            this.comboBoxSinifOgretmeni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSinifOgretmeni.FormattingEnabled = true;
            this.comboBoxSinifOgretmeni.Location = new System.Drawing.Point(173, 108);
            this.comboBoxSinifOgretmeni.Name = "comboBoxSinifOgretmeni";
            this.comboBoxSinifOgretmeni.Size = new System.Drawing.Size(198, 28);
            this.comboBoxSinifOgretmeni.TabIndex = 7;
            // 
            // textBoxSinifSubesi
            // 
            this.textBoxSinifSubesi.Location = new System.Drawing.Point(173, 61);
            this.textBoxSinifSubesi.Name = "textBoxSinifSubesi";
            this.textBoxSinifSubesi.Size = new System.Drawing.Size(198, 26);
            this.textBoxSinifSubesi.TabIndex = 6;
            // 
            // textBoxSinifNo
            // 
            this.textBoxSinifNo.Location = new System.Drawing.Point(173, 26);
            this.textBoxSinifNo.Name = "textBoxSinifNo";
            this.textBoxSinifNo.Size = new System.Drawing.Size(198, 26);
            this.textBoxSinifNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "AKTİF Mİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "BÖLÜMÜ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "SINIF ÖĞRETMENİ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SINIF ŞUBESİ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SINIF NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewSiniflar);
            this.groupBox2.Location = new System.Drawing.Point(0, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 406);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SINIFLAR";
            // 
            // dataGridViewSiniflar
            // 
            this.dataGridViewSiniflar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiniflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSiniflar.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewSiniflar.Name = "dataGridViewSiniflar";
            this.dataGridViewSiniflar.Size = new System.Drawing.Size(799, 387);
            this.dataGridViewSiniflar.TabIndex = 0;
            this.dataGridViewSiniflar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiniflar_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonTemizle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonKaydet
            // 
            this.toolStripButtonKaydet.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButtonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKaydet.Image")));
            this.toolStripButtonKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKaydet.Name = "toolStripButtonKaydet";
            this.toolStripButtonKaydet.Size = new System.Drawing.Size(75, 24);
            this.toolStripButtonKaydet.Text = "Kaydet";
            this.toolStripButtonKaydet.Click += new System.EventHandler(this.toolStripButtonKaydet_Click);
            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButtonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelle.Image")));
            this.toolStripButtonGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(86, 24);
            this.toolStripButtonGuncelle.Text = "Güncelle";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);
            // 
            // toolStripButtonTemizle
            // 
            this.toolStripButtonTemizle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButtonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTemizle.Image")));
            this.toolStripButtonTemizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTemizle.Name = "toolStripButtonTemizle";
            this.toolStripButtonTemizle.Size = new System.Drawing.Size(80, 24);
            this.toolStripButtonTemizle.Text = "Temizle";
            this.toolStripButtonTemizle.Click += new System.EventHandler(this.toolStripButtonTemizle_Click);
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
            this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(45, 24);
            this.toolStripButtonSil.Text = "Sil";
            this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);
            // 
            // FormSinifListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 630);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSinifListesi";
            this.Text = "Sınıf Listesi";
            this.Load += new System.EventHandler(this.FormSinifListesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiniflar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonPasif;
        private System.Windows.Forms.RadioButton radioButtonAktif;
        private System.Windows.Forms.ComboBox comboBoxBolumu;
        private System.Windows.Forms.ComboBox comboBoxSinifOgretmeni;
        private System.Windows.Forms.TextBox textBoxSinifSubesi;
        private System.Windows.Forms.TextBox textBoxSinifNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewSiniflar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonTemizle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
    }
}

