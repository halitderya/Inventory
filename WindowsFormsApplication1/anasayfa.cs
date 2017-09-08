using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class anasayfa : Form
    {
        kayıtekle frm2 = new kayıtekle();
        sil frm3 = new sil();
        guncelle frm4 = new guncelle();
        durumekle frm5 = new durumekle();
        durumara frm6 = new durumara();
        durumsil frm7 = new durumsil();
        tipara frm9 = new tipara();
        varlikara frm8 = new varlikara();



        public anasayfa()
        {
            InitializeComponent();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void durumAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm6.Show();
            this.Hide();
            
        }

        private void varlıkAraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void varlıkEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        private void varlıkSİlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3.Show();
            this.Hide();
        }

        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void durumEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm5.Show();
            this.Hide();
        }

        private void durumSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm7.Show();
            this.Hide();
        }

        private void durumPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barkodNumarasındanAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm8.Show();
            this.Hide();


        }

        private void ürünTipindenAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm9.Show();
            this.Hide();


         

        }

        private void zimmetleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm4.Show();
            this.Hide();
        }

        private void varlıkGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitguncelle frm82 = new kayitguncelle();
            frm82.Show();
            this.Hide();


        }

  
    }
}
