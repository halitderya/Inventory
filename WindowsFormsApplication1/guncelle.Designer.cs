namespace WindowsFormsApplication1
{
    partial class guncelle
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
            this.combobarkod = new System.Windows.Forms.ComboBox();
            this.eNVTABLOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eNVANTERDataSet6 = new WindowsFormsApplication1.ENVANTERDataSet6();
            this.eNVTABLOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNVANTERDataSet = new WindowsFormsApplication1.ENVANTERDataSet();
            this.sahiplikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNVANTERDataSet1 = new WindowsFormsApplication1.ENVANTERDataSet1();
            this.dateislemtar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.butonguncelle = new System.Windows.Forms.Button();
            this.eNVTABLOTableAdapter = new WindowsFormsApplication1.ENVANTERDataSetTableAdapters.ENVTABLOTableAdapter();
            this.sahiplikTableAdapter = new WindowsFormsApplication1.ENVANTERDataSet1TableAdapters.sahiplikTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplication1.ENVANTERDataSet1TableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.URUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.işlemci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satinalmatarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid3 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sahiplikBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.eNVANTERDataSet4 = new WindowsFormsApplication1.ENVANTERDataSet4();
            this.sahiplikBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.eNVANTERDataSet3 = new WindowsFormsApplication1.ENVANTERDataSet3();
            this.sahiplikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eNVANTERDataSet2 = new WindowsFormsApplication1.ENVANTERDataSet2();
            this.sahiplikBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sahiplikTableAdapter1 = new WindowsFormsApplication1.ENVANTERDataSet2TableAdapters.sahiplikTableAdapter();
            this.sahiplikTableAdapter2 = new WindowsFormsApplication1.ENVANTERDataSet3TableAdapters.sahiplikTableAdapter();
            this.sahiplikTableAdapter3 = new WindowsFormsApplication1.ENVANTERDataSet4TableAdapters.sahiplikTableAdapter();
            this.eNVTABLOTableAdapter1 = new WindowsFormsApplication1.ENVANTERDataSet6TableAdapters.ENVTABLOTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOYADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIRKET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GOREVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eNVTABLOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVTABLOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplikBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplikBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplikBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // combobarkod
            // 
            this.combobarkod.FormattingEnabled = true;
            this.combobarkod.Location = new System.Drawing.Point(143, 19);
            this.combobarkod.Name = "combobarkod";
            this.combobarkod.Size = new System.Drawing.Size(100, 21);
            this.combobarkod.TabIndex = 0;
            this.combobarkod.SelectedIndexChanged += new System.EventHandler(this.combobarkod_SelectedIndexChanged);
            // 
            // eNVTABLOBindingSource1
            // 
            this.eNVTABLOBindingSource1.DataMember = "ENVTABLO";
            this.eNVTABLOBindingSource1.DataSource = this.eNVANTERDataSet6;
            // 
            // eNVANTERDataSet6
            // 
            this.eNVANTERDataSet6.DataSetName = "ENVANTERDataSet6";
            this.eNVANTERDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eNVTABLOBindingSource
            // 
            this.eNVTABLOBindingSource.DataMember = "ENVTABLO";
            this.eNVTABLOBindingSource.DataSource = this.eNVANTERDataSet;
            // 
            // eNVANTERDataSet
            // 
            this.eNVANTERDataSet.DataSetName = "ENVANTERDataSet";
            this.eNVANTERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sahiplikBindingSource
            // 
            this.sahiplikBindingSource.DataMember = "sahiplik";
            this.sahiplikBindingSource.DataSource = this.eNVANTERDataSet1;
            // 
            // eNVANTERDataSet1
            // 
            this.eNVANTERDataSet1.DataSetName = "ENVANTERDataSet1";
            this.eNVANTERDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateislemtar
            // 
            this.dateislemtar.CustomFormat = "yyyy-MM-dd";
            this.dateislemtar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateislemtar.Location = new System.Drawing.Point(331, 216);
            this.dateislemtar.Name = "dateislemtar";
            this.dateislemtar.Size = new System.Drawing.Size(100, 20);
            this.dateislemtar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Barkod Numarası";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(249, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "İşlem Tarihi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Şuna Güncelle";
            // 
            // butonguncelle
            // 
            this.butonguncelle.BackColor = System.Drawing.Color.Salmon;
            this.butonguncelle.Location = new System.Drawing.Point(271, 333);
            this.butonguncelle.Name = "butonguncelle";
            this.butonguncelle.Size = new System.Drawing.Size(210, 35);
            this.butonguncelle.TabIndex = 25;
            this.butonguncelle.Text = "Güncelle...";
            this.butonguncelle.UseVisualStyleBackColor = false;
            this.butonguncelle.Click += new System.EventHandler(this.butonguncelle_Click);
            // 
            // eNVTABLOTableAdapter
            // 
            this.eNVTABLOTableAdapter.ClearBeforeFill = true;
            // 
            // sahiplikTableAdapter
            // 
            this.sahiplikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.sahiplikTableAdapter = this.sahiplikTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplication1.ENVANTERDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.URUN,
            this.marka,
            this.MODEL,
            this.seri});
            this.dataGridView1.Location = new System.Drawing.Point(25, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(543, 42);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // URUN
            // 
            this.URUN.DataPropertyName = "ÜRÜN TİPİ";
            this.URUN.HeaderText = "ÜRÜN TİPİ";
            this.URUN.Name = "URUN";
            this.URUN.ReadOnly = true;
            // 
            // marka
            // 
            this.marka.DataPropertyName = "Marka";
            this.marka.HeaderText = "MARKASI";
            this.marka.Name = "marka";
            this.marka.ReadOnly = true;
            // 
            // MODEL
            // 
            this.MODEL.DataPropertyName = "Model / Sürüm";
            this.MODEL.HeaderText = "MODEL / SÜRÜM";
            this.MODEL.Name = "MODEL";
            this.MODEL.ReadOnly = true;
            // 
            // seri
            // 
            this.seri.DataPropertyName = "Seri No";
            this.seri.HeaderText = "SERİ NUMARASI";
            this.seri.Name = "seri";
            this.seri.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.işlemci,
            this.RAM,
            this.HDD,
            this.HDD2,
            this.satinalmatarihi});
            this.dataGridView2.Location = new System.Drawing.Point(25, 143);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 200;
            this.dataGridView2.Size = new System.Drawing.Size(543, 55);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // işlemci
            // 
            this.işlemci.DataPropertyName = "işlemci";
            this.işlemci.HeaderText = "İŞLEMCİ";
            this.işlemci.Name = "işlemci";
            this.işlemci.ReadOnly = true;
            // 
            // RAM
            // 
            this.RAM.DataPropertyName = "ram";
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            // 
            // HDD
            // 
            this.HDD.DataPropertyName = "hdd";
            this.HDD.HeaderText = "HDD1";
            this.HDD.Name = "HDD";
            this.HDD.ReadOnly = true;
            // 
            // HDD2
            // 
            this.HDD2.DataPropertyName = "hdd2";
            this.HDD2.HeaderText = "HDD2";
            this.HDD2.Name = "HDD2";
            this.HDD2.ReadOnly = true;
            // 
            // satinalmatarihi
            // 
            this.satinalmatarihi.DataPropertyName = "Ürün Giriş Tarihi";
            this.satinalmatarihi.HeaderText = "SATIN ALMA TARİHİ";
            this.satinalmatarihi.Name = "satinalmatarihi";
            this.satinalmatarihi.ReadOnly = true;
            // 
            // grid3
            // 
            this.grid3.AllowUserToAddRows = false;
            this.grid3.AllowUserToDeleteRows = false;
            this.grid3.AllowUserToResizeColumns = false;
            this.grid3.AllowUserToResizeRows = false;
            this.grid3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ADI,
            this.SOYADI,
            this.SIRKET,
            this.DEPARTMAN,
            this.GOREVI});
            this.grid3.Location = new System.Drawing.Point(25, 270);
            this.grid3.Name = "grid3";
            this.grid3.ReadOnly = true;
            this.grid3.RowHeadersVisible = false;
            this.grid3.Size = new System.Drawing.Size(543, 43);
            this.grid3.TabIndex = 28;
            this.grid3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sahiplikBindingSource4
            // 
            this.sahiplikBindingSource4.DataMember = "sahiplik";
            this.sahiplikBindingSource4.DataSource = this.eNVANTERDataSet4;
            this.sahiplikBindingSource4.Sort = "TAMADI";
            // 
            // eNVANTERDataSet4
            // 
            this.eNVANTERDataSet4.DataSetName = "ENVANTERDataSet4";
            this.eNVANTERDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sahiplikBindingSource3
            // 
            this.sahiplikBindingSource3.DataMember = "sahiplik";
            this.sahiplikBindingSource3.DataSource = this.eNVANTERDataSet3;
            // 
            // eNVANTERDataSet3
            // 
            this.eNVANTERDataSet3.DataSetName = "ENVANTERDataSet3";
            this.eNVANTERDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sahiplikBindingSource1
            // 
            this.sahiplikBindingSource1.DataMember = "sahiplik";
            this.sahiplikBindingSource1.DataSource = this.eNVANTERDataSet1;
            // 
            // eNVANTERDataSet2
            // 
            this.eNVANTERDataSet2.DataSetName = "ENVANTERDataSet2";
            this.eNVANTERDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sahiplikBindingSource2
            // 
            this.sahiplikBindingSource2.DataMember = "sahiplik";
            this.sahiplikBindingSource2.DataSource = this.eNVANTERDataSet2;
            // 
            // sahiplikTableAdapter1
            // 
            this.sahiplikTableAdapter1.ClearBeforeFill = true;
            // 
            // sahiplikTableAdapter2
            // 
            this.sahiplikTableAdapter2.ClearBeforeFill = true;
            // 
            // sahiplikTableAdapter3
            // 
            this.sahiplikTableAdapter3.ClearBeforeFill = true;
            // 
            // eNVTABLOTableAdapter1
            // 
            this.eNVTABLOTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ADI
            // 
            this.ADI.DataPropertyName = "AD";
            this.ADI.HeaderText = "Adı";
            this.ADI.Name = "ADI";
            this.ADI.ReadOnly = true;
            // 
            // SOYADI
            // 
            this.SOYADI.DataPropertyName = "SOYAD";
            this.SOYADI.HeaderText = "Soyadı";
            this.SOYADI.Name = "SOYADI";
            this.SOYADI.ReadOnly = true;
            // 
            // SIRKET
            // 
            this.SIRKET.DataPropertyName = "FIRMA";
            this.SIRKET.HeaderText = "Şirket";
            this.SIRKET.Name = "SIRKET";
            this.SIRKET.ReadOnly = true;
            // 
            // DEPARTMAN
            // 
            this.DEPARTMAN.DataPropertyName = "DEPARTMAN";
            this.DEPARTMAN.HeaderText = "Departman";
            this.DEPARTMAN.Name = "DEPARTMAN";
            this.DEPARTMAN.ReadOnly = true;
            // 
            // GOREVI
            // 
            this.GOREVI.DataPropertyName = "GOREV";
            this.GOREVI.HeaderText = "Görevi";
            this.GOREVI.Name = "GOREVI";
            this.GOREVI.ReadOnly = true;
            // 
            // guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grid3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butonguncelle);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateislemtar);
            this.Controls.Add(this.combobarkod);
            this.Name = "guncelle";
            this.Text = "Kayıt Güncelle";
            this.Load += new System.EventHandler(this.guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eNVTABLOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVTABLOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplikBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplikBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sahiplikBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobarkod;
        private System.Windows.Forms.DateTimePicker dateislemtar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button butonguncelle;
        private ENVANTERDataSet eNVANTERDataSet;
        private System.Windows.Forms.BindingSource eNVTABLOBindingSource;
        private ENVANTERDataSetTableAdapters.ENVTABLOTableAdapter eNVTABLOTableAdapter;
        private ENVANTERDataSet1 eNVANTERDataSet1;
        private System.Windows.Forms.BindingSource sahiplikBindingSource;
        private ENVANTERDataSet1TableAdapters.sahiplikTableAdapter sahiplikTableAdapter;
        private ENVANTERDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn seri;
        private System.Windows.Forms.DataGridViewTextBoxColumn işlemci;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD2;
        private System.Windows.Forms.DataGridViewTextBoxColumn satinalmatarihi;
        private System.Windows.Forms.DataGridView grid3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sahiplikBindingSource1;
        private ENVANTERDataSet2 eNVANTERDataSet2;
        private System.Windows.Forms.BindingSource sahiplikBindingSource2;
        private ENVANTERDataSet2TableAdapters.sahiplikTableAdapter sahiplikTableAdapter1;
        private ENVANTERDataSet3 eNVANTERDataSet3;
        private System.Windows.Forms.BindingSource sahiplikBindingSource3;
        private ENVANTERDataSet3TableAdapters.sahiplikTableAdapter sahiplikTableAdapter2;
        private ENVANTERDataSet4 eNVANTERDataSet4;
        private System.Windows.Forms.BindingSource sahiplikBindingSource4;
        private ENVANTERDataSet4TableAdapters.sahiplikTableAdapter sahiplikTableAdapter3;
        private ENVANTERDataSet6 eNVANTERDataSet6;
        private System.Windows.Forms.BindingSource eNVTABLOBindingSource1;
        private ENVANTERDataSet6TableAdapters.ENVTABLOTableAdapter eNVTABLOTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOYADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIRKET;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GOREVI;

    }
}