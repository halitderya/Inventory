using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class anasayfakul : Form
    {
        private string brk;
        public string passvalue
        {
            get { return brk; }
            set { brk = value; }

        }


        
       
        
        



        public anasayfakul()
        {
            InitializeComponent();
        }


        private void grafiksorgulari()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT * from ENVTABLO inner join sahiplik inner join personel", conn);
            SqlCommand cmd2 = new SqlCommand("select *from envtablo", conn);
            SqlCommand sayenv = new SqlCommand("select count (*) from ENVTABLO", conn);
            SqlCommand sahipsiz = new SqlCommand("select count (*) from ENVTABLO full outer join sahiplik on sahiplik.BARKOD=ENVTABLO.BARKOD where sahiplik.BARKOD is null or ENVTABLO.BARKOD is null", conn);
            conn.Open();
            string bgnzimstr = "select count (*) from ENVTABLO inner join sahiplik on ENVTABLO.BARKOD=sahiplik.BARKOD where zimmet_tarihi >= DATEADD(day, -1, GETDATE())";
            SqlCommand sahipli = new SqlCommand("select distinct count (*) from ENVTABLO inner join sahiplik on ENVTABLO.BARKOD=sahiplik.BARKOD", conn);
            SqlCommand bugunzimcom = new SqlCommand(bgnzimstr, conn);
            string bgnzimm = bugunzimcom.ExecuteScalar().ToString();
            DataTable dt = new DataTable();
            SqlDataAdapter bigda = new SqlDataAdapter("select count (*) from ENVTABLO", conn);
            SqlDataAdapter sahda= new SqlDataAdapter("select count (*) from ENVTABLO inner join sahiplik on ENVTABLO.BARKOD=sahiplik.BARKOD", conn);
            SqlDataAdapter sahipsizda = new SqlDataAdapter("select count (*) from ENVTABLO full outer join sahiplik on sahiplik.BARKOD=ENVTABLO.BARKOD where sahiplik.BARKOD is null ", conn);
            SqlDataAdapter bugunzimmet = new SqlDataAdapter(bgnzimstr, conn);
            SqlDataAdapter cmd3 = new SqlDataAdapter("select  count ([ÜRÜN TİPİ]) as ADET,[ÜRÜN TİPİ] AS [ÜRÜN TİPİ] from ENVTABLO where [ürün tipi] is not null group by [ÜRÜN TİPİ]  ", conn);
            bigda.Fill(dt);
            sahda.Fill(dt);
            bugunzimmet.Fill(dt);
            sahipsizda.Fill(dt);
            cmd3.Fill(dt);
           

            string yirmidort = "";

            if (bgnzimm.Equals ("0") )
            {
                
            }

            else
            {
                yirmidort = "Ayrıca son 24 saat içerisinde " + (dt.Rows[2][0].ToString()) + " adet zimmet yapılmış.";
            }
            
            label3.Text = "Şuan itibariyle envanter sistemine " + (dt.Rows[0][0].ToString()) + " adet cihaz kayıtlı!";
            label4.Text = "Bunlardan " + (dt.Rows[1][0].ToString()) + " tanesi zimmetlenmiş.";
            label11.Text = yirmidort.ToString();
            chart1.Series[0].Points.AddXY("Zimmetli",dt.Rows[1][0].ToString());
            chart1.Series[0].Points.AddXY("Zimmetsiz",dt.Rows[3][0].ToString());
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.ChartAreas[0].Area3DStyle.Inclination = 20;




        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

            string gun;
            var hours = DateTime.Now.Hour;
            
            if (hours > 16)
            {
                gun = "İyi Akşamlar ";
            }
            else if (hours > 11)
            {
                gun = "Tünaydın ";
            }
            else
            {
                gun = "Günaydın ";
            }
            
            label6.Text = gun + brk.ToLower() + "!" + " Bugün nasılsın?";
            label1.Text = brk;

            grafiksorgulari();

            label2.Text = "Biliyor Musunuz;";
            label9.Text= DateTime.Today.ToString("D");
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void durumAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumara frm6 = new durumara();
            frm6.Show();
        }

        private void varlıkAraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void varlıkEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayıtekle frm2 = new kayıtekle();
            frm2.Show();
            
        }

        private void varlıkSİlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sil frm3 = new sil();
            frm3.Show();
        }

        private void programdanÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void durumEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumekle frm5 = new durumekle();
            frm5.Show();
        }

        private void durumSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumsil frm7 = new durumsil();

            frm7.Show();
        }

        private void durumPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void barkodNumarasındanAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barkodara frm8 = new barkodara();

            frm8.Show();


        }

        private void ürünTipindenAraToolStripMenuItem_Click(object sender, EventArgs e)
        {



         

        }

        private void zimmetleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncelle gunc = new guncelle();
            gunc.guncpass = label1.Text;
            gunc.Show();
        }

        private void varlıkGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kayitguncelle frm82 = new kayitguncelle();
            frm82.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           // qrcode frmqr = new qrcode();
           // frmqr.Show();
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giris gir = new giris();
            gir.Show();
            this.Close();

        }

        private void departmanBazındaRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raporlama1 rpr = new raporlama1();
            rpr.Show();
        }

        private void ürünTipindenAraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tipara frm9 = new tipara();

            frm9.Show();
        }

        private void firmaBazındaRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firmaara frmara = new firmaara();
            frmara.Show();
               
        }

        private void personelÜzerindekiZimmetlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            persara PRS = new persara();
            PRS.Show();
        }

        private void varlıkGeçmişiniGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gecmisara GEC = new gecmisara();
            GEC.Show();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Formlar.cesitli.hakkinda hak = new WindowsFormsApplication1.Formlar.cesitli.hakkinda();
            hak.Show();

        
        }

        private void tümÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tumara tum = new tumara();
            tum.Show();
        }

        private void sahipsizÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sahipsiz shp = new sahipsiz();
            shp.Show();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           WindowsFormsApplication1.Formlar.cesitli.password_reset_self prs = new WindowsFormsApplication1.Formlar.cesitli.password_reset_self();
            prs.passvalue = brk;
            prs.Show();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tipara kaygun = new tipara();
            kaygun.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            barkodara gunc = new barkodara();
            gunc.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sahipsiz sahp = new sahipsiz();
            sahp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            durumara pers = new durumara();
            pers.Show();

        }

        private void seriNumarasındanAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seriara ser = new seriara();
            ser.Show();
        }

        private void nasılKullanılırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlar.cesitli.yardim yrd = new Formlar.cesitli.yardim();
            yrd.Show();
        }
    }
}
