﻿namespace WindowsFormsApplication1
{
    partial class sahipsiz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sahipsiz));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uruntipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Windows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.datasettiparaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasettiparaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sahipsiz  Varlıkları Ara";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uruntipi,
            this.tip,
            this.Marka,
            this.model,
            this.seri,
            this.HDD,
            this.HDD2,
            this.cpu,
            this.RAM,
            this.Windows,
            this.Office});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GrayText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(730, 447);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uruntipi
            // 
            this.uruntipi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.uruntipi.DataPropertyName = "BARKOD";
            this.uruntipi.FillWeight = 142.132F;
            this.uruntipi.Frozen = true;
            this.uruntipi.HeaderText = "Barkod";
            this.uruntipi.Name = "uruntipi";
            this.uruntipi.ReadOnly = true;
            this.uruntipi.Width = 47;
            // 
            // tip
            // 
            this.tip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tip.DataPropertyName = "ÜRÜN TİPİ";
            this.tip.FillWeight = 50.75608F;
            this.tip.Frozen = true;
            this.tip.HeaderText = "Ürün Tipi";
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.Width = 77;
            // 
            // Marka
            // 
            this.Marka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Marka.DataPropertyName = "Marka";
            this.Marka.FillWeight = 114.352F;
            this.Marka.Frozen = true;
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            this.Marka.ReadOnly = true;
            this.Marka.Width = 64;
            // 
            // model
            // 
            this.model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.model.DataPropertyName = "Model / Sürüm";
            this.model.FillWeight = 85.70536F;
            this.model.Frozen = true;
            this.model.HeaderText = "Model / Sürüm";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Width = 106;
            // 
            // seri
            // 
            this.seri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.seri.DataPropertyName = "Seri No";
            this.seri.FillWeight = 64.36588F;
            this.seri.Frozen = true;
            this.seri.HeaderText = "Seri No";
            this.seri.Name = "seri";
            this.seri.ReadOnly = true;
            this.seri.Width = 68;
            // 
            // HDD
            // 
            this.HDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HDD.DataPropertyName = "HDD";
            this.HDD.FillWeight = 48.48298F;
            this.HDD.Frozen = true;
            this.HDD.HeaderText = "HDD";
            this.HDD.Name = "HDD";
            this.HDD.ReadOnly = true;
            this.HDD.Width = 36;
            // 
            // HDD2
            // 
            this.HDD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HDD2.DataPropertyName = "HDD2";
            this.HDD2.FillWeight = 36.67634F;
            this.HDD2.Frozen = true;
            this.HDD2.HeaderText = "HDD2";
            this.HDD2.Name = "HDD2";
            this.HDD2.ReadOnly = true;
            this.HDD2.Width = 45;
            // 
            // cpu
            // 
            this.cpu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cpu.DataPropertyName = "İşlemci";
            this.cpu.FillWeight = 27.42234F;
            this.cpu.Frozen = true;
            this.cpu.HeaderText = "İşlemci";
            this.cpu.Name = "cpu";
            this.cpu.ReadOnly = true;
            this.cpu.Width = 67;
            // 
            // RAM
            // 
            this.RAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RAM.DataPropertyName = "ram";
            this.RAM.FillWeight = 20.51705F;
            this.RAM.Frozen = true;
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            this.RAM.Width = 56;
            // 
            // Windows
            // 
            this.Windows.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Windows.DataPropertyName = "İşletim Sistemi";
            this.Windows.FillWeight = 15.36439F;
            this.Windows.Frozen = true;
            this.Windows.HeaderText = "Windows";
            this.Windows.Name = "Windows";
            this.Windows.ReadOnly = true;
            this.Windows.Width = 78;
            // 
            // Office
            // 
            this.Office.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Office.DataPropertyName = "Office";
            this.Office.FillWeight = 6.509627F;
            this.Office.Frozen = true;
            this.Office.HeaderText = "Office";
            this.Office.Name = "Office";
            this.Office.ReadOnly = true;
            this.Office.Width = 61;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(382, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(382, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "Getir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(260, 577);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 22);
            this.button3.TabIndex = 7;
            this.button3.Text = "Excel \'e çıkart";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sahipsiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(754, 611);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sahipsiz";
            this.Text = "Sahipsiz Varlık Arama";
            this.Load += new System.EventHandler(this.sahipsiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasettiparaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource datasettiparaBindingSource;
        //private datasettipara datasettipara;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn uruntipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn seri;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Windows;
        private System.Windows.Forms.DataGridViewTextBoxColumn Office;
    }
}