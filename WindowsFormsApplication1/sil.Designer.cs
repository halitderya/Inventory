namespace WindowsFormsApplication1
{
    partial class sil
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eNVTABLOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNVANTERDataSet = new WindowsFormsApplication1.ENVANTERDataSet();
            this.eNVTABLOTableAdapter = new WindowsFormsApplication1.ENVANTERDataSetTableAdapters.ENVTABLOTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BARKOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URUNTIPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARKA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVTABLOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(335, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kayıt Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BARKOD,
            this.URUNTIPI,
            this.MARKA,
            this.MODEL,
            this.Serino});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(673, 53);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // eNVTABLOTableAdapter
            // 
            this.eNVTABLOTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(189, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gold;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(288, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 22);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(191, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Barkod Numarası:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(449, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Getir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BARKOD
            // 
            this.BARKOD.DataPropertyName = "BARKOD";
            this.BARKOD.HeaderText = "Barkod";
            this.BARKOD.Name = "BARKOD";
            this.BARKOD.ReadOnly = true;
            // 
            // URUNTIPI
            // 
            this.URUNTIPI.DataPropertyName = "ürün tipi";
            this.URUNTIPI.HeaderText = "Ürün Tipi";
            this.URUNTIPI.Name = "URUNTIPI";
            this.URUNTIPI.ReadOnly = true;
            // 
            // MARKA
            // 
            this.MARKA.DataPropertyName = "MARKA";
            this.MARKA.HeaderText = "Marka";
            this.MARKA.Name = "MARKA";
            this.MARKA.ReadOnly = true;
            // 
            // MODEL
            // 
            this.MODEL.DataPropertyName = "Model / Sürüm";
            this.MODEL.HeaderText = "Model";
            this.MODEL.Name = "MODEL";
            this.MODEL.ReadOnly = true;
            // 
            // Serino
            // 
            this.Serino.DataPropertyName = "Seri No";
            this.Serino.HeaderText = "Seri No";
            this.Serino.Name = "Serino";
            this.Serino.ReadOnly = true;
            // 
            // sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(697, 216);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "sil";
            this.Text = "Varlık Sil";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVTABLOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNVANTERDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ENVANTERDataSet eNVANTERDataSet;
        private System.Windows.Forms.BindingSource eNVTABLOBindingSource;
        private ENVANTERDataSetTableAdapters.ENVTABLOTableAdapter eNVTABLOTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARKOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUNTIPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARKA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serino;

    }
}