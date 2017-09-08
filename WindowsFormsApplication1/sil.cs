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
    public partial class sil : Form
    {
        public sil()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT BARKOD from ENVTABLO", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                comboBox1.Items.Add(dr["BARKOD"]);
            
                        conn.Close();



            // TODO: This line of code loads data into the 'eNVANTERDataSet.ENVTABLO' table. You can move, or remove it, as needed.
        //    this.eNVTABLOTableAdapter.Fill(this.eNVANTERDataSet.ENVTABLO);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            sil frmsil = new sil();
            string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            baglan.Open();
            if (MessageBox.Show(comboBox1.SelectedItem + " Barkod nolu ürün Silinecektir. Bu işlem geri alınamaz. Devam Etmek İstiyor Musunuz?", "Silme İşlemini Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                 SqlCommand sil = new SqlCommand("delete from ENVTABLO where BARKOD='" +comboBox1.SelectedItem+ "'",baglan);
               // sil.ExecuteNonQuery();
                int etkilenenKayitSayisi = sil.ExecuteNonQuery();
                MessageBox.Show(etkilenenKayitSayisi.ToString() + " Kayıt Silindi","Bilgi");
                dataGridView1.DataSource = (sil);
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
            anasayfa frm4 = new anasayfa();

            frm4.Show();
            this.Hide();
        }

   //     private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
     //   {

       // }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string baglancumlesi = "Data Source=IT-HALITDERYA3\\SQLEXPRESS;Initial Catalog=ENVANTER;Integrated Security=True;";
            SqlConnection baglan = new SqlConnection(baglancumlesi);
            baglan.Open();
            SqlCommand getir = new SqlCommand ("select BARKOD,[ürün tipi],MARKA,[MODEL / SÜRÜM],[seri no] from ENVTABLO where BARKOD='" + comboBox1.Text + "'",baglan);
            baglan.Close();
            SqlDataAdapter da = new SqlDataAdapter(getir);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = (dt);
            baglan.Close();

        }
    }
}
