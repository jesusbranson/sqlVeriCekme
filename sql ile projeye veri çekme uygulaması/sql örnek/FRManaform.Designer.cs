namespace sql_örnek
{
    partial class FRManaform
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRManaform));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskMAAS = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cmbSEHİR = new System.Windows.Forms.ComboBox();
            this.txtMESLEK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLİSTELE = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGRAFİK = new System.Windows.Forms.Button();
            this.btnİSTATİSTİK = new System.Windows.Forms.Button();
            this.btnTEMİZLE = new System.Windows.Forms.Button();
            this.btnGÜNCELLE = new System.Windows.Forms.Button();
            this.btnKAYDET = new System.Windows.Forms.Button();
            this.btnSİL = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSEHİRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMAASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMESLEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPERSONELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet = new sql_örnek.PersonelDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PERSONELTableAdapter = new sql_örnek.PersonelDataSetTableAdapters.tbl_PERSONELTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPERSONELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.mskMAAS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.cmbSEHİR);
            this.groupBox1.Controls.Add(this.txtMESLEK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSOYAD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // mskMAAS
            // 
            this.mskMAAS.Location = new System.Drawing.Point(109, 165);
            this.mskMAAS.Mask = "0000";
            this.mskMAAS.Name = "mskMAAS";
            this.mskMAAS.Size = new System.Drawing.Size(100, 20);
            this.mskMAAS.TabIndex = 5;
            this.mskMAAS.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Personel Maaş:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(167, 188);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(42, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Evli";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(109, 188);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bekar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cmbSEHİR
            // 
            this.cmbSEHİR.FormattingEnabled = true;
            this.cmbSEHİR.Location = new System.Drawing.Point(109, 130);
            this.cmbSEHİR.Name = "cmbSEHİR";
            this.cmbSEHİR.Size = new System.Drawing.Size(100, 21);
            this.cmbSEHİR.TabIndex = 4;
            // 
            // txtMESLEK
            // 
            this.txtMESLEK.Location = new System.Drawing.Point(109, 211);
            this.txtMESLEK.Name = "txtMESLEK";
            this.txtMESLEK.Size = new System.Drawing.Size(100, 20);
            this.txtMESLEK.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Personel Meslek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Personel Durum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Personel Şehir:";
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(109, 104);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(100, 20);
            this.txtSOYAD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personel Soyad:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(109, 78);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(100, 20);
            this.txtAD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Personel Ad:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(109, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID:";
            // 
            // btnLİSTELE
            // 
            this.btnLİSTELE.Location = new System.Drawing.Point(6, 19);
            this.btnLİSTELE.Name = "btnLİSTELE";
            this.btnLİSTELE.Size = new System.Drawing.Size(222, 26);
            this.btnLİSTELE.TabIndex = 13;
            this.btnLİSTELE.Text = "Personel Listele";
            this.btnLİSTELE.UseVisualStyleBackColor = true;
            this.btnLİSTELE.Click += new System.EventHandler(this.btnLİSTELE_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnGRAFİK);
            this.groupBox2.Controls.Add(this.btnİSTATİSTİK);
            this.groupBox2.Controls.Add(this.btnTEMİZLE);
            this.groupBox2.Controls.Add(this.btnGÜNCELLE);
            this.groupBox2.Controls.Add(this.btnKAYDET);
            this.groupBox2.Controls.Add(this.btnSİL);
            this.groupBox2.Controls.Add(this.btnLİSTELE);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnGRAFİK
            // 
            this.btnGRAFİK.Location = new System.Drawing.Point(6, 209);
            this.btnGRAFİK.Name = "btnGRAFİK";
            this.btnGRAFİK.Size = new System.Drawing.Size(222, 26);
            this.btnGRAFİK.TabIndex = 19;
            this.btnGRAFİK.Text = "Grafikler";
            this.btnGRAFİK.UseVisualStyleBackColor = true;
            this.btnGRAFİK.Click += new System.EventHandler(this.btnGRAFİK_Click);
            // 
            // btnİSTATİSTİK
            // 
            this.btnİSTATİSTİK.Location = new System.Drawing.Point(6, 177);
            this.btnİSTATİSTİK.Name = "btnİSTATİSTİK";
            this.btnİSTATİSTİK.Size = new System.Drawing.Size(222, 26);
            this.btnİSTATİSTİK.TabIndex = 18;
            this.btnİSTATİSTİK.Text = "İstatistik";
            this.btnİSTATİSTİK.UseVisualStyleBackColor = true;
            this.btnİSTATİSTİK.Click += new System.EventHandler(this.btnİSTATİSTİK_Click);
            // 
            // btnTEMİZLE
            // 
            this.btnTEMİZLE.Location = new System.Drawing.Point(6, 145);
            this.btnTEMİZLE.Name = "btnTEMİZLE";
            this.btnTEMİZLE.Size = new System.Drawing.Size(222, 26);
            this.btnTEMİZLE.TabIndex = 17;
            this.btnTEMİZLE.Text = "Bilgileri Temizle";
            this.btnTEMİZLE.UseVisualStyleBackColor = true;
            this.btnTEMİZLE.Click += new System.EventHandler(this.btnTEMİZLE_Click);
            // 
            // btnGÜNCELLE
            // 
            this.btnGÜNCELLE.Location = new System.Drawing.Point(6, 113);
            this.btnGÜNCELLE.Name = "btnGÜNCELLE";
            this.btnGÜNCELLE.Size = new System.Drawing.Size(222, 26);
            this.btnGÜNCELLE.TabIndex = 16;
            this.btnGÜNCELLE.Text = "Personel Kayıt Güncelle";
            this.btnGÜNCELLE.UseVisualStyleBackColor = true;
            this.btnGÜNCELLE.Click += new System.EventHandler(this.btnGÜNCELLE_Click);
            // 
            // btnKAYDET
            // 
            this.btnKAYDET.Location = new System.Drawing.Point(6, 51);
            this.btnKAYDET.Name = "btnKAYDET";
            this.btnKAYDET.Size = new System.Drawing.Size(222, 26);
            this.btnKAYDET.TabIndex = 15;
            this.btnKAYDET.Text = "Personel Kaydet";
            this.btnKAYDET.UseVisualStyleBackColor = true;
            this.btnKAYDET.Click += new System.EventHandler(this.btnKAYDET_Click);
            // 
            // btnSİL
            // 
            this.btnSİL.Location = new System.Drawing.Point(6, 81);
            this.btnSİL.Name = "btnSİL";
            this.btnSİL.Size = new System.Drawing.Size(222, 26);
            this.btnSİL.TabIndex = 14;
            this.btnSİL.Text = "Personel Kayıt Sil";
            this.btnSİL.UseVisualStyleBackColor = true;
            this.btnSİL.Click += new System.EventHandler(this.btnSİL_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(9, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 268);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perADDataGridViewTextBoxColumn,
            this.perSOYADDataGridViewTextBoxColumn,
            this.perSEHİRDataGridViewTextBoxColumn,
            this.perMAASDataGridViewTextBoxColumn,
            this.perDURUMDataGridViewCheckBoxColumn,
            this.perMESLEKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPERSONELBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "perID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "perID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perADDataGridViewTextBoxColumn
            // 
            this.perADDataGridViewTextBoxColumn.DataPropertyName = "perAD";
            this.perADDataGridViewTextBoxColumn.HeaderText = "perAD";
            this.perADDataGridViewTextBoxColumn.Name = "perADDataGridViewTextBoxColumn";
            // 
            // perSOYADDataGridViewTextBoxColumn
            // 
            this.perSOYADDataGridViewTextBoxColumn.DataPropertyName = "perSOYAD";
            this.perSOYADDataGridViewTextBoxColumn.HeaderText = "perSOYAD";
            this.perSOYADDataGridViewTextBoxColumn.Name = "perSOYADDataGridViewTextBoxColumn";
            // 
            // perSEHİRDataGridViewTextBoxColumn
            // 
            this.perSEHİRDataGridViewTextBoxColumn.DataPropertyName = "perSEHİR";
            this.perSEHİRDataGridViewTextBoxColumn.HeaderText = "perSEHİR";
            this.perSEHİRDataGridViewTextBoxColumn.Name = "perSEHİRDataGridViewTextBoxColumn";
            // 
            // perMAASDataGridViewTextBoxColumn
            // 
            this.perMAASDataGridViewTextBoxColumn.DataPropertyName = "perMAAS";
            this.perMAASDataGridViewTextBoxColumn.HeaderText = "perMAAS";
            this.perMAASDataGridViewTextBoxColumn.Name = "perMAASDataGridViewTextBoxColumn";
            // 
            // perDURUMDataGridViewCheckBoxColumn
            // 
            this.perDURUMDataGridViewCheckBoxColumn.DataPropertyName = "perDURUM";
            this.perDURUMDataGridViewCheckBoxColumn.HeaderText = "perDURUM";
            this.perDURUMDataGridViewCheckBoxColumn.Name = "perDURUMDataGridViewCheckBoxColumn";
            // 
            // perMESLEKDataGridViewTextBoxColumn
            // 
            this.perMESLEKDataGridViewTextBoxColumn.DataPropertyName = "perMESLEK";
            this.perMESLEKDataGridViewTextBoxColumn.HeaderText = "perMESLEK";
            this.perMESLEKDataGridViewTextBoxColumn.Name = "perMESLEKDataGridViewTextBoxColumn";
            // 
            // tblPERSONELBindingSource
            // 
            this.tblPERSONELBindingSource.DataMember = "tbl_PERSONEL";
            this.tblPERSONELBindingSource.DataSource = this.personelDataSet;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "PersonelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PERSONELTableAdapter
            // 
            this.tbl_PERSONELTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(721, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 26);
            this.button1.TabIndex = 20;
            this.button1.Text = "Raporlama";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FRManaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRManaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip Sistemi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPERSONELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSEHİR;
        private System.Windows.Forms.Button btnLİSTELE;
        private System.Windows.Forms.TextBox txtMESLEK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGRAFİK;
        private System.Windows.Forms.Button btnİSTATİSTİK;
        private System.Windows.Forms.Button btnTEMİZLE;
        private System.Windows.Forms.Button btnGÜNCELLE;
        private System.Windows.Forms.Button btnKAYDET;
        private System.Windows.Forms.Button btnSİL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskMAAS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource tblPERSONELBindingSource;
        private PersonelDataSetTableAdapters.tbl_PERSONELTableAdapter tbl_PERSONELTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSEHİRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMAASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDURUMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMESLEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

