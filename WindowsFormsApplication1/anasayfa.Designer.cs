namespace WindowsFormsApplication1
{
    partial class anasayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.varlıklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varlıkAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barkodNumarasındanAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünTipindenAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varlıkGeçmişiniGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varlıkEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varlıkSİlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durumPersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durumAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durumEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durumSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zimmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zimmetAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barkoddanVarlıkSahibiBulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personeleKayıtlıVarlıkSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanaKayıtlıVarlıkSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zimmetleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanBazındaRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaBazındaRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boştakiVarlıklarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programdanÇıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oturumuKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasılKullanılırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varlıkGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varlıklarToolStripMenuItem,
            this.durumPersonelToolStripMenuItem,
            this.zimmetToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // varlıklarToolStripMenuItem
            // 
            this.varlıklarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varlıkAraToolStripMenuItem,
            this.varlıkEkleToolStripMenuItem,
            this.varlıkSİlToolStripMenuItem,
            this.varlıkGüncelleToolStripMenuItem});
            this.varlıklarToolStripMenuItem.Name = "varlıklarToolStripMenuItem";
            this.varlıklarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.varlıklarToolStripMenuItem.Text = "Varlıklar";
            // 
            // varlıkAraToolStripMenuItem
            // 
            this.varlıkAraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barkodNumarasındanAraToolStripMenuItem,
            this.ürünTipindenAraToolStripMenuItem,
            this.varlıkGeçmişiniGörüntüleToolStripMenuItem});
            this.varlıkAraToolStripMenuItem.Name = "varlıkAraToolStripMenuItem";
            this.varlıkAraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.varlıkAraToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.varlıkAraToolStripMenuItem.Text = "Varlık Ara";
            this.varlıkAraToolStripMenuItem.Click += new System.EventHandler(this.varlıkAraToolStripMenuItem_Click);
            // 
            // barkodNumarasındanAraToolStripMenuItem
            // 
            this.barkodNumarasındanAraToolStripMenuItem.Name = "barkodNumarasındanAraToolStripMenuItem";
            this.barkodNumarasındanAraToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.barkodNumarasındanAraToolStripMenuItem.Text = "Barkod Numarasından Ara";
            this.barkodNumarasındanAraToolStripMenuItem.Click += new System.EventHandler(this.barkodNumarasındanAraToolStripMenuItem_Click);
            // 
            // ürünTipindenAraToolStripMenuItem
            // 
            this.ürünTipindenAraToolStripMenuItem.Name = "ürünTipindenAraToolStripMenuItem";
            this.ürünTipindenAraToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ürünTipindenAraToolStripMenuItem.Text = "Ürün Tipinden Ara";
            this.ürünTipindenAraToolStripMenuItem.Click += new System.EventHandler(this.ürünTipindenAraToolStripMenuItem_Click);
            // 
            // varlıkGeçmişiniGörüntüleToolStripMenuItem
            // 
            this.varlıkGeçmişiniGörüntüleToolStripMenuItem.Name = "varlıkGeçmişiniGörüntüleToolStripMenuItem";
            this.varlıkGeçmişiniGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.varlıkGeçmişiniGörüntüleToolStripMenuItem.Text = "Varlık Geçmişini Görüntüle";
            // 
            // varlıkEkleToolStripMenuItem
            // 
            this.varlıkEkleToolStripMenuItem.Name = "varlıkEkleToolStripMenuItem";
            this.varlıkEkleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.varlıkEkleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.varlıkEkleToolStripMenuItem.Text = "Varlık Ekle";
            this.varlıkEkleToolStripMenuItem.Click += new System.EventHandler(this.varlıkEkleToolStripMenuItem_Click);
            // 
            // varlıkSİlToolStripMenuItem
            // 
            this.varlıkSİlToolStripMenuItem.Name = "varlıkSİlToolStripMenuItem";
            this.varlıkSİlToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.varlıkSİlToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.varlıkSİlToolStripMenuItem.Text = "Varlık Sil";
            this.varlıkSİlToolStripMenuItem.Click += new System.EventHandler(this.varlıkSİlToolStripMenuItem_Click);
            // 
            // durumPersonelToolStripMenuItem
            // 
            this.durumPersonelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durumAraToolStripMenuItem,
            this.durumEkleToolStripMenuItem,
            this.durumSilToolStripMenuItem});
            this.durumPersonelToolStripMenuItem.Name = "durumPersonelToolStripMenuItem";
            this.durumPersonelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.durumPersonelToolStripMenuItem.Text = "Personel";
            this.durumPersonelToolStripMenuItem.Click += new System.EventHandler(this.durumPersonelToolStripMenuItem_Click);
            // 
            // durumAraToolStripMenuItem
            // 
            this.durumAraToolStripMenuItem.Name = "durumAraToolStripMenuItem";
            this.durumAraToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.durumAraToolStripMenuItem.Text = "Personel Ara";
            this.durumAraToolStripMenuItem.Click += new System.EventHandler(this.durumAraToolStripMenuItem_Click);
            // 
            // durumEkleToolStripMenuItem
            // 
            this.durumEkleToolStripMenuItem.Name = "durumEkleToolStripMenuItem";
            this.durumEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.durumEkleToolStripMenuItem.Text = "Personel Ekle";
            this.durumEkleToolStripMenuItem.Click += new System.EventHandler(this.durumEkleToolStripMenuItem_Click);
            // 
            // durumSilToolStripMenuItem
            // 
            this.durumSilToolStripMenuItem.Name = "durumSilToolStripMenuItem";
            this.durumSilToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.durumSilToolStripMenuItem.Text = "Personel Sil";
            this.durumSilToolStripMenuItem.Click += new System.EventHandler(this.durumSilToolStripMenuItem_Click);
            // 
            // zimmetToolStripMenuItem
            // 
            this.zimmetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zimmetAraToolStripMenuItem,
            this.zimmetleToolStripMenuItem});
            this.zimmetToolStripMenuItem.Name = "zimmetToolStripMenuItem";
            this.zimmetToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.zimmetToolStripMenuItem.Text = "Zimmet";
            // 
            // zimmetAraToolStripMenuItem
            // 
            this.zimmetAraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barkoddanVarlıkSahibiBulToolStripMenuItem,
            this.personeleKayıtlıVarlıkSorgulaToolStripMenuItem,
            this.departmanaKayıtlıVarlıkSorgulaToolStripMenuItem});
            this.zimmetAraToolStripMenuItem.Name = "zimmetAraToolStripMenuItem";
            this.zimmetAraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.zimmetAraToolStripMenuItem.Text = "Zimmet Ara";
            // 
            // barkoddanVarlıkSahibiBulToolStripMenuItem
            // 
            this.barkoddanVarlıkSahibiBulToolStripMenuItem.Name = "barkoddanVarlıkSahibiBulToolStripMenuItem";
            this.barkoddanVarlıkSahibiBulToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.barkoddanVarlıkSahibiBulToolStripMenuItem.Text = "Barkoddan Varlık Sahibi Bul";
            // 
            // personeleKayıtlıVarlıkSorgulaToolStripMenuItem
            // 
            this.personeleKayıtlıVarlıkSorgulaToolStripMenuItem.Name = "personeleKayıtlıVarlıkSorgulaToolStripMenuItem";
            this.personeleKayıtlıVarlıkSorgulaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.personeleKayıtlıVarlıkSorgulaToolStripMenuItem.Text = "Personele Kayıtlı Varlık Sorgula";
            // 
            // departmanaKayıtlıVarlıkSorgulaToolStripMenuItem
            // 
            this.departmanaKayıtlıVarlıkSorgulaToolStripMenuItem.Name = "departmanaKayıtlıVarlıkSorgulaToolStripMenuItem";
            this.departmanaKayıtlıVarlıkSorgulaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.departmanaKayıtlıVarlıkSorgulaToolStripMenuItem.Text = "Departmana Kayıtlı Varlık Sorgula";
            // 
            // zimmetleToolStripMenuItem
            // 
            this.zimmetleToolStripMenuItem.Name = "zimmetleToolStripMenuItem";
            this.zimmetleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.zimmetleToolStripMenuItem.Text = "Zimmetle";
            this.zimmetleToolStripMenuItem.Click += new System.EventHandler(this.zimmetleToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmanBazındaRaporToolStripMenuItem,
            this.firmaBazındaRaporToolStripMenuItem,
            this.boştakiVarlıklarToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // departmanBazındaRaporToolStripMenuItem
            // 
            this.departmanBazındaRaporToolStripMenuItem.Name = "departmanBazındaRaporToolStripMenuItem";
            this.departmanBazındaRaporToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.departmanBazındaRaporToolStripMenuItem.Text = "Departman Bazında Rapor";
            // 
            // firmaBazındaRaporToolStripMenuItem
            // 
            this.firmaBazındaRaporToolStripMenuItem.Name = "firmaBazındaRaporToolStripMenuItem";
            this.firmaBazındaRaporToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.firmaBazındaRaporToolStripMenuItem.Text = "Firma Bazında Rapor";
            // 
            // boştakiVarlıklarToolStripMenuItem
            // 
            this.boştakiVarlıklarToolStripMenuItem.Name = "boştakiVarlıklarToolStripMenuItem";
            this.boştakiVarlıklarToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.boştakiVarlıklarToolStripMenuItem.Text = "Boştaki Varlıklar";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programdanÇıkToolStripMenuItem,
            this.oturumuKapatToolStripMenuItem});
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // programdanÇıkToolStripMenuItem
            // 
            this.programdanÇıkToolStripMenuItem.Name = "programdanÇıkToolStripMenuItem";
            this.programdanÇıkToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.programdanÇıkToolStripMenuItem.Text = "Programdan Çık";
            this.programdanÇıkToolStripMenuItem.Click += new System.EventHandler(this.programdanÇıkToolStripMenuItem_Click);
            // 
            // oturumuKapatToolStripMenuItem
            // 
            this.oturumuKapatToolStripMenuItem.Name = "oturumuKapatToolStripMenuItem";
            this.oturumuKapatToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.oturumuKapatToolStripMenuItem.Text = "Oturumu Kapat";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem,
            this.nasılKullanılırToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // nasılKullanılırToolStripMenuItem
            // 
            this.nasılKullanılırToolStripMenuItem.Name = "nasılKullanılırToolStripMenuItem";
            this.nasılKullanılırToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nasılKullanılırToolStripMenuItem.Text = "Nasıl Kullanılır?";
            // 
            // varlıkGüncelleToolStripMenuItem
            // 
            this.varlıkGüncelleToolStripMenuItem.Name = "varlıkGüncelleToolStripMenuItem";
            this.varlıkGüncelleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.varlıkGüncelleToolStripMenuItem.Text = "Varlık Güncelle";
            this.varlıkGüncelleToolStripMenuItem.Click += new System.EventHandler(this.varlıkGüncelleToolStripMenuItem_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.inventory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(433, 248);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "anasayfa";
            this.Text = "BT Varlık Yönetim Sistemi";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem varlıklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varlıkAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varlıkEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varlıkSİlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durumPersonelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durumAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durumEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durumSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanBazındaRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaBazındaRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boştakiVarlıklarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasılKullanılırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programdanÇıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oturumuKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zimmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zimmetAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barkoddanVarlıkSahibiBulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeleKayıtlıVarlıkSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanaKayıtlıVarlıkSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zimmetleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barkodNumarasındanAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünTipindenAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varlıkGeçmişiniGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varlıkGüncelleToolStripMenuItem;
    }
}