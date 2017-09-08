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
            SqlConnection conn = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True");
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

          anasayfa frm1 = new anasayfa();
          frm1.Show();
          this.Close();

                       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & comboBox2.SelectedIndex > -1 & comboBox3.SelectedIndex >-1 )
            {
                string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;MultipleActiveResultSets=True;";
                SqlConnection baglan = new SqlConnection(baglancumlesi);
                SqlConnection baglan2 = new SqlConnection(baglancumlesi);
                baglan.Open();
                string durumkayit = "insert into PERSONEL (AD,SOYAD,FIRMA,DEPARTMAN,GOREV) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "')";
                SqlCommand komut = new SqlCommand(durumkayit, baglan);
                int sayi = komut.ExecuteNonQuery();
                baglan.Close();
                baglan2.Open();
                string tamadekle= "UPDATE PERSONEL SET (TAMAD = AD +' '+ SOYAD)";
                SqlCommand tamad = new SqlCommand(tamadekle,baglan2);
                baglan2.Close();

                if (sayi > 0)
                {
                    MessageBox.Show(textBox1.Text + " " + textBox2.Text + " Eklendi");

                baglan.Close();
                    
                textBox1.Text = "";
                textBox2.Text = "";
                textBox4.Text = "";
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;


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

