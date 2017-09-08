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


namespace WindowsFormsApplication1.Formlar.cesitli
{
    public partial class password_reset : Form
    {
        public password_reset()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand denetle = new SqlCommand("select *from kullanici where ad=('" + comboBox1.Text + "')", baglan);






        }

        private void password_reset_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT ad from kullanici", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ad"]);
                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0 & comboBox1.SelectedIndex > -1)
            {
                
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
                conn.Open();
                SqlCommand guncelle = new SqlCommand("update kullanici set sifre=('" + textBox3.Text + "') where ad=('" + comboBox1.Text + "')", conn);
                if (guncelle.ExecuteNonQuery() >0 )
                {
                    MessageBox.Show("Şifre Değiştirilmiştir.","İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else{
                    MessageBox.Show("İşlem Başarısız","Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                

            }
            else 
            {
                MessageBox.Show("Lütffen Gerekli Alanları Doldurunuz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            if ( textBox1.Text.Length > 0 & textBox2.Text.Length> 0 )
            {
                int yetki = 0;
                if (comboBox2.SelectedIndex== -1)
                {
                    yetki = yetki + 1;
                }
                else if (comboBox2.SelectedIndex == 0)
                {
                    yetki = yetki + 1;
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    yetki = yetki + 2;
                }
               SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
                conn.Open();
                SqlCommand ekle = new SqlCommand("insert into kullanici (ad,sifre,yetki)  values ('" + textBox1.Text + "', '" + textBox2.Text + "' , '"+yetki+"')", conn);

            
                

                MessageBox.Show(textBox1.Text + " Kullanıcısı Oluşturuldu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

             
                if (ekle.ExecuteNonQuery() > 0)
                {
                   

                }
                else
                {
                    
                    MessageBox.Show("İşlem Başarısız","Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }

                conn.Close();
            }
            else
            {
             
                MessageBox.Show("Lütffen Gerekli Alanları Doldurunuz", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
          
            }

  

        }
    }
}
