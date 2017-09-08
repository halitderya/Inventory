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
    public partial class password_reset_self : Form
    {
        private string brk;
        public string passvalue
        {
            get { return brk; }
            set { brk = value; }

        }


        public password_reset_self()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand denetle = new SqlCommand("select *from kullanici where ad=('" + textBox1.Text + "')", baglan);






        }

        private void password_reset_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = brk;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0 & textBox1.Text.Length > 0)
            {
                
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
                conn.Open();
                SqlCommand guncelle = new SqlCommand("update kullanici set sifre=('" + textBox3.Text + "') where ad=('" + textBox1.Text + "')", conn);
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
          
          
               SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
                conn.Open();
              

  

        }
    }
}
