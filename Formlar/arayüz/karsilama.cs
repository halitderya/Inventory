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
    public partial class karsilama : Form

    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); 

        private string brk;
        public string passvalue
        {
            get { return brk; }
            set { brk = value; }
            
        }





        public karsilama()
        {
            InitializeComponent();




        }

        private void karsilama_Load(object sender, EventArgs e)
        {
            timer.Interval = 1500;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            brk = brk.ToLower();
            label1.Text = "Hoş Geldin " + brk + "!";
            




           
        }
        void timer_Tick(object sender, EventArgs e)
        {

            label2.Text = brk;
            SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            conn2.Open();
            SqlCommand yetkom = new SqlCommand("SELECT * from kullanici where yetki=2 and ad='" + label2.Text + "'", conn2);
            SqlDataReader yetkdr;
            yetkdr = yetkom.ExecuteReader();
            int yetkgir = 0;
            while (yetkdr.Read())
            {
                yetkgir = yetkgir + 1;
            }
            if (yetkgir == 1)
            {
                anasayfa ana = new anasayfa();
                ana.passvalue = label2.Text;
                ana.Show();
                this.Hide();
                timer.Stop();
            }
            
            else
            {    anasayfakul anakul = new anasayfakul();
                anakul.passvalue = label2.Text;
                anakul.Show();
                this.Hide();
                timer.Stop();
            }

            conn2.Close();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = brk;

        }
    
    
    }
}
