namespace WindowsFormsApplication1
{
    partial class durumsil
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sirket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gorevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 22);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adı,
            this.Soyadı,
            this.Sirket,
            this.Departman,
            this.Gorevi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(583, 44);
            this.dataGridView1.TabIndex = 2;
            // 
            // Adı
            // 
            this.Adı.DataPropertyName = "AD";
            this.Adı.HeaderText = "Adı";
            this.Adı.Name = "Adı";
            this.Adı.ReadOnly = true;
            // 
            // Soyadı
            // 
            this.Soyadı.DataPropertyName = "SOYAD";
            this.Soyadı.HeaderText = "Soyadı";
            this.Soyadı.Name = "Soyadı";
            this.Soyadı.ReadOnly = true;
            // 
            // Sirket
            // 
            this.Sirket.DataPropertyName = "FIRMA";
            this.Sirket.HeaderText = "Şirket";
            this.Sirket.Name = "Sirket";
            this.Sirket.ReadOnly = true;
            // 
            // Departman
            // 
            this.Departman.DataPropertyName = "DEPARTMAN";
            this.Departman.HeaderText = "Departmanı";
            this.Departman.Name = "Departman";
            this.Departman.ReadOnly = true;
            // 
            // Gorevi
            // 
            this.Gorevi.DataPropertyName = "GOREV";
            this.Gorevi.HeaderText = "Görevi";
            this.Gorevi.Name = "Gorevi";
            this.Gorevi.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(346, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(225, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 22);
            this.button3.TabIndex = 4;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Silinecek Kayıt:";
            // 
            // durumsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(623, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "durumsil";
            this.Text = "Durum / Personel Sil";
            this.Load += new System.EventHandler(this.durumsil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sirket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gorevi;
        private System.Windows.Forms.Label label1;
    }
}