namespace Personel_Kayit_Uygulamasi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnBekar = new System.Windows.Forms.RadioButton();
            this.rdbtnEvli = new System.Windows.Forms.RadioButton();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtPerMeslek = new System.Windows.Forms.TextBox();
            this.lblMeslek = new System.Windows.Forms.Label();
            this.mskTxtPerMaas = new System.Windows.Forms.MaskedTextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.cmbPerSehir = new System.Windows.Forms.ComboBox();
            this.lbSehir = new System.Windows.Forms.Label();
            this.txtPerSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtPerId = new System.Windows.Forms.TextBox();
            this.lblPerId = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personelMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDBDataSet = new Personel_Kayit_Uygulamasi.PersonelDBDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new Personel_Kayit_Uygulamasi.PersonelDBDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnBekar);
            this.groupBox1.Controls.Add(this.rdbtnEvli);
            this.groupBox1.Controls.Add(this.lblDurum);
            this.groupBox1.Controls.Add(this.txtPerMeslek);
            this.groupBox1.Controls.Add(this.lblMeslek);
            this.groupBox1.Controls.Add(this.mskTxtPerMaas);
            this.groupBox1.Controls.Add(this.lblMaas);
            this.groupBox1.Controls.Add(this.cmbPerSehir);
            this.groupBox1.Controls.Add(this.lbSehir);
            this.groupBox1.Controls.Add(this.txtPerSoyad);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.txtPerAd);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.txtPerId);
            this.groupBox1.Controls.Add(this.lblPerId);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(414, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbtnBekar
            // 
            this.rdbtnBekar.AutoSize = true;
            this.rdbtnBekar.Location = new System.Drawing.Point(317, 334);
            this.rdbtnBekar.Name = "rdbtnBekar";
            this.rdbtnBekar.Size = new System.Drawing.Size(74, 30);
            this.rdbtnBekar.TabIndex = 14;
            this.rdbtnBekar.TabStop = true;
            this.rdbtnBekar.Text = "Bekar";
            this.rdbtnBekar.UseVisualStyleBackColor = true;
            this.rdbtnBekar.CheckedChanged += new System.EventHandler(this.rdbtnBekar_CheckedChanged);
            // 
            // rdbtnEvli
            // 
            this.rdbtnEvli.AutoSize = true;
            this.rdbtnEvli.Location = new System.Drawing.Point(211, 336);
            this.rdbtnEvli.Name = "rdbtnEvli";
            this.rdbtnEvli.Size = new System.Drawing.Size(63, 30);
            this.rdbtnEvli.TabIndex = 13;
            this.rdbtnEvli.TabStop = true;
            this.rdbtnEvli.Text = "Evli";
            this.rdbtnEvli.UseVisualStyleBackColor = true;
            this.rdbtnEvli.CheckedChanged += new System.EventHandler(this.rdbtnEvli_CheckedChanged);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurum.Location = new System.Drawing.Point(22, 338);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(158, 26);
            this.lblDurum.TabIndex = 12;
            this.lblDurum.Text = "Personel Durum :";
            // 
            // txtPerMeslek
            // 
            this.txtPerMeslek.Location = new System.Drawing.Point(211, 390);
            this.txtPerMeslek.Margin = new System.Windows.Forms.Padding(6);
            this.txtPerMeslek.Name = "txtPerMeslek";
            this.txtPerMeslek.Size = new System.Drawing.Size(180, 33);
            this.txtPerMeslek.TabIndex = 11;
            // 
            // lblMeslek
            // 
            this.lblMeslek.AutoSize = true;
            this.lblMeslek.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeslek.Location = new System.Drawing.Point(34, 393);
            this.lblMeslek.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMeslek.Name = "lblMeslek";
            this.lblMeslek.Size = new System.Drawing.Size(156, 26);
            this.lblMeslek.TabIndex = 10;
            this.lblMeslek.Text = "Personel Meslek :";
            // 
            // mskTxtPerMaas
            // 
            this.mskTxtPerMaas.Location = new System.Drawing.Point(211, 281);
            this.mskTxtPerMaas.Mask = "00000";
            this.mskTxtPerMaas.Name = "mskTxtPerMaas";
            this.mskTxtPerMaas.Size = new System.Drawing.Size(180, 33);
            this.mskTxtPerMaas.TabIndex = 9;
            this.mskTxtPerMaas.ValidatingType = typeof(int);
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaas.Location = new System.Drawing.Point(22, 284);
            this.lblMaas.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(141, 26);
            this.lblMaas.TabIndex = 8;
            this.lblMaas.Text = "Personel Maaş :";
            // 
            // cmbPerSehir
            // 
            this.cmbPerSehir.FormattingEnabled = true;
            this.cmbPerSehir.Location = new System.Drawing.Point(211, 230);
            this.cmbPerSehir.Name = "cmbPerSehir";
            this.cmbPerSehir.Size = new System.Drawing.Size(180, 34);
            this.cmbPerSehir.TabIndex = 7;
            // 
            // lbSehir
            // 
            this.lbSehir.AutoSize = true;
            this.lbSehir.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSehir.Location = new System.Drawing.Point(22, 233);
            this.lbSehir.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSehir.Name = "lbSehir";
            this.lbSehir.Size = new System.Drawing.Size(139, 26);
            this.lbSehir.TabIndex = 6;
            this.lbSehir.Text = "Personel Şehir :";
            // 
            // txtPerSoyad
            // 
            this.txtPerSoyad.Location = new System.Drawing.Point(211, 173);
            this.txtPerSoyad.Margin = new System.Windows.Forms.Padding(6);
            this.txtPerSoyad.Name = "txtPerSoyad";
            this.txtPerSoyad.Size = new System.Drawing.Size(180, 33);
            this.txtPerSoyad.TabIndex = 5;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoyad.Location = new System.Drawing.Point(22, 176);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(147, 26);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Personel Soyad :";
            // 
            // txtPerAd
            // 
            this.txtPerAd.Location = new System.Drawing.Point(211, 114);
            this.txtPerAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(180, 33);
            this.txtPerAd.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.Location = new System.Drawing.Point(22, 117);
            this.lblAd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(122, 26);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Personel Ad :";
            // 
            // txtPerId
            // 
            this.txtPerId.Location = new System.Drawing.Point(211, 51);
            this.txtPerId.Margin = new System.Windows.Forms.Padding(6);
            this.txtPerId.Name = "txtPerId";
            this.txtPerId.Size = new System.Drawing.Size(180, 33);
            this.txtPerId.TabIndex = 1;
            // 
            // lblPerId
            // 
            this.lblPerId.AutoSize = true;
            this.lblPerId.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerId.Location = new System.Drawing.Point(22, 54);
            this.lblPerId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPerId.Name = "lblPerId";
            this.lblPerId.Size = new System.Drawing.Size(115, 26);
            this.lblPerId.TabIndex = 0;
            this.lblPerId.Text = "Personel Id :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrafik);
            this.groupBox2.Controls.Add(this.btnIstatistik);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Location = new System.Drawing.Point(426, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(228, 467);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(26, 381);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(177, 33);
            this.btnGrafik.TabIndex = 21;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(26, 335);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(177, 33);
            this.btnIstatistik.TabIndex = 20;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(26, 284);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(177, 33);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(26, 230);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(177, 33);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(29, 176);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(177, 33);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(29, 114);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(177, 33);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(29, 51);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(177, 33);
            this.btnListele.TabIndex = 15;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.personelAdDataGridViewTextBoxColumn,
            this.personelSoyadDataGridViewTextBoxColumn,
            this.personelSehirDataGridViewTextBoxColumn,
            this.personelMaasDataGridViewTextBoxColumn,
            this.personelDurumDataGridViewCheckBoxColumn,
            this.personelMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(879, 243);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            // 
            // personelAdDataGridViewTextBoxColumn
            // 
            this.personelAdDataGridViewTextBoxColumn.DataPropertyName = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.HeaderText = "PersonelAd";
            this.personelAdDataGridViewTextBoxColumn.Name = "personelAdDataGridViewTextBoxColumn";
            // 
            // personelSoyadDataGridViewTextBoxColumn
            // 
            this.personelSoyadDataGridViewTextBoxColumn.DataPropertyName = "PersonelSoyad";
            this.personelSoyadDataGridViewTextBoxColumn.HeaderText = "PersonelSoyad";
            this.personelSoyadDataGridViewTextBoxColumn.Name = "personelSoyadDataGridViewTextBoxColumn";
            // 
            // personelSehirDataGridViewTextBoxColumn
            // 
            this.personelSehirDataGridViewTextBoxColumn.DataPropertyName = "PersonelSehir";
            this.personelSehirDataGridViewTextBoxColumn.HeaderText = "PersonelSehir";
            this.personelSehirDataGridViewTextBoxColumn.Name = "personelSehirDataGridViewTextBoxColumn";
            // 
            // personelMaasDataGridViewTextBoxColumn
            // 
            this.personelMaasDataGridViewTextBoxColumn.DataPropertyName = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.HeaderText = "PersonelMaas";
            this.personelMaasDataGridViewTextBoxColumn.Name = "personelMaasDataGridViewTextBoxColumn";
            // 
            // personelDurumDataGridViewCheckBoxColumn
            // 
            this.personelDurumDataGridViewCheckBoxColumn.DataPropertyName = "PersonelDurum";
            this.personelDurumDataGridViewCheckBoxColumn.HeaderText = "PersonelDurum";
            this.personelDurumDataGridViewCheckBoxColumn.Name = "personelDurumDataGridViewCheckBoxColumn";
            // 
            // personelMeslekDataGridViewTextBoxColumn
            // 
            this.personelMeslekDataGridViewTextBoxColumn.DataPropertyName = "PersonelMeslek";
            this.personelMeslekDataGridViewTextBoxColumn.HeaderText = "PersonelMeslek";
            this.personelMeslekDataGridViewTextBoxColumn.Name = "personelMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelDBDataSet;
            // 
            // personelDBDataSet
            // 
            this.personelDBDataSet.DataSetName = "PersonelDBDataSet";
            this.personelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(0, 479);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(891, 281);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-73, 420);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(663, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(894, 765);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPerId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPerId;
        private System.Windows.Forms.TextBox txtPerMeslek;
        private System.Windows.Forms.Label lblMeslek;
        private System.Windows.Forms.MaskedTextBox mskTxtPerMaas;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.ComboBox cmbPerSehir;
        private System.Windows.Forms.Label lbSehir;
        private System.Windows.Forms.TextBox txtPerSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtPerAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.RadioButton rdbtnBekar;
        private System.Windows.Forms.RadioButton rdbtnEvli;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelDBDataSet personelDBDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelDBDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personelDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelMeslekDataGridViewTextBoxColumn;
    }
}

