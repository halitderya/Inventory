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
    public partial class sil : Form
    {


        public sil()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ToString());
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT BARKOD from ENVTABLO", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())

            {
               
                comboBox1.Items.Add(dr["BARKOD"]);
            }
                        conn.Close();



 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            sil frmsil = new sil();
            string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            baglan.Open();
            if (MessageBox.Show(comboBox1.SelectedItem + " Barkod nolu ürün Silinecektir. Bu işlem geri alınamaz. Devam Etmek İstiyor Musunuz?", "Silme İşlemini Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                 SqlCommand sil = new SqlCommand("delete from ENVTABLO where BARKOD='" +comboBox1.SelectedItem+ "'",baglan);
               // sil.ExecuteNonQuery();
                 int etkilenenKayitSayisi = sil.ExecuteNonQuery();
                MessageBox.Show(etkilenenKayitSayisi.ToString() + " Kayıt Silindi","Bilgi");
                dataGridView1.DataSource = (sil);
                comboBox1.Items.Remove(comboBox1.SelectedItem);

                SqlCommand cmd = new SqlCommand("SELECT DISTINCT BARKOD from ENVTABLO", baglan);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())

               comboBox1.Items.Add(dr["BARKOD"]);
            }
            else
            {
                frmsil.Show();
                this.Hide();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

   //     private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
     //   {

       // }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string baglancumlesi = ConfigurationManager.ConnectionStrings["connection"].ToString();
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            baglan.Open();
            SqlCommand getir = new SqlCommand("select BARKOD,[ÜRÜN TİPİ],Marka,[Model / Sürüm],[Seri No] from ENVTABLO where BARKOD='" + comboBox1.Text + "'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = (dt);
                        baglan.Close();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
