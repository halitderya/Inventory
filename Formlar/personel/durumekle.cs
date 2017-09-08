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
    public partial class durumekle : Form
    {
        public durumekle()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)

        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT FIRMA from PERSONEL", conn);
            SqlCommand cmd2 = new SqlCommand("SELECT DISTINCT DEPARTMAN from PERSONEL", conn);
   
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["FIRMA"]);
            }
            conn.Close();
            conn.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                comboBox2.Items.Add(dr2["DEPARTMAN"]);
            }
           conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


          this.Close();

                       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0  & textBox2.Text.Trim().Length > 0  & comboBox2.Text.Trim().Length > 0 & comboBox3.Text.Trim().Length >0 )
            {
                string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();
                SqlConnection baglan = new SqlConnection(baglancumlesi);
                SqlConnection baglan2 = new SqlConnection(baglancumlesi);
                baglan.Open();
                string durumkayit = "insert into PERSONEL (AD,SOYAD,FIRMA,DEPARTMAN,GOREV,TAMAD) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','"+ textBox1.Text +"' + ' ' + '"+textBox2.Text+"')";
                SqlCommand komut = new SqlCommand(durumkayit, baglan);
                int sayi = komut.ExecuteNonQuery();
                baglan.Close();

                if (sayi > 0)
                {
                    MessageBox.Show(textBox1.Text + " " + textBox2.Text + " Eklendi");

                baglan.Close();
                    
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";


                }
                else
                {
                MessageBox.Show("Hiçbir Kayıt Eklenemedi","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            else
            {
                MessageBox.Show("* İle İşaretli Alanların Doldurulması Gerekir.","Eksik Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
            


        }
    }

