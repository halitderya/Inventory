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
    public partial class durumara : Form
    {
        public durumara()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            baglan.Open();
            DataTable dt = new DataTable();
            string araisim = "SELECT AD,SOYAD,GOREV,FIRMA,DEPARTMAN FROM PERSONEL where AD like ('" + textBox1.Text + "') ";
            string arasoyisim = "SELECT AD,SOYAD,GOREV,FIRMA,DEPARTMAN FROM PERSONEL where SOYAD like ('" + textBox2.Text + "') ";
            string araisimvesoyisim = "SELECT AD,SOYAD,GOREV,FIRMA,DEPARTMAN FROM PERSONEL where AD like ('" + textBox1.Text + "') and SOYAD like ( '" + textBox2.Text + "')";
            string aradepartman = "SELECT AD,SOYAD,GOREV,FIRMA,DEPARTMAN FROM PERSONEL WHERE DEPARTMAN like ('" + comboBox2.Text + "')";
            dataGridView1.DataSource = dt;

            if (comboBox2.Text.Trim().Length>0 & ( textBox1.Text.Trim().Length >0 | textBox2.Text.Trim().Length>0 ))
            {
                
                MessageBox.Show(this, "Departman Aramalarında İsim/Soyisim Önemsenmez.", "Bilgi", MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                textBox1.Text = "";
                textBox2.Text = "";
                                SqlCommand komut2 = new SqlCommand(aradepartman, baglan);
                SqlDataAdapter da = new SqlDataAdapter(komut2);


                da.Fill(dt);
                baglan.Close();

            }


            else if (comboBox2.Text.Trim().Length > 0 & textBox1.Text.Trim().Length==0 & textBox2.Text.Trim().Length==0)

            {
                SqlCommand komut2 = new SqlCommand(aradepartman, baglan);
                SqlDataAdapter da = new SqlDataAdapter(komut2);
                da.Fill(dt);
                baglan.Close();
            }


            else if ( textBox1.Text.Trim().Length > 0 & textBox2.Text.Trim().Length == 0)
            {
                SqlCommand komut2 = new SqlCommand(araisim, baglan);
                SqlDataAdapter da = new SqlDataAdapter(komut2);
                da.Fill(dt);

                SqlDataReader reader = komut2.ExecuteReader();






                baglan.Close();


            }
            else if (textBox1.Text.Trim().Length == 0 & textBox2.Text.Trim().Length > 0)
            {
                SqlCommand komut2 = new SqlCommand(arasoyisim, baglan);
                SqlDataAdapter da = new SqlDataAdapter(komut2);
                da.Fill(dt);
                baglan.Close();

            }
            
            else if (textBox1.Text.Trim().Length > 0 & textBox2.Text.Trim().Length > 0)
            
            {
                SqlCommand komut2 = new SqlCommand(araisimvesoyisim, baglan);
                SqlDataAdapter da = new SqlDataAdapter(komut2);
                da.Fill(dt);
                baglan.Close();
                
            }



            else
            {
                MessageBox.Show("Bilinmeyen Hata","Hata",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            

            baglan.Close();


        }
           
            private void durumara_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT DEPARTMAN from PERSONEL", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())

comboBox2.Items.Add(dr["DEPARTMAN"]);

          conn.Close();

            
            }
    
  

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.AllowUserToAddRows = false;

        }

 

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa frm1 = new anasayfa();
            frm1.Show();
            this.Close();
        }



        
    }

}